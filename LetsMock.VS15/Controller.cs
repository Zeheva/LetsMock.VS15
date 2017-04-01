using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMock.VS15
{
   public class Controller
    {
        IDashboard dashboard = new Dashboard();
        ISensor sensor = new Sensor();
        IHVAC hvac = new HVAC();

        public Controller(IDashboard dashboard, ISensor sensor, IHVAC hvac)
        {
            if(dashboard == null) { throw new ArgumentNullException(nameof(dashboard)); }
            if(sensor == null) { throw new ArgumentNullException(nameof(sensor)); }
            if(hvac == null) { throw new ArgumentNullException(nameof(hvac)); }

            this.dashboard = dashboard;
            this.sensor = sensor;
            this.hvac = hvac;
        }

        public void Execute()
        {

            var desiredTemperature = dashboard.GetDesiredTemperature();

            var currentTemperatrue = sensor.Read();


            if (currentTemperatrue < desiredTemperature)
            {
                hvac.Heat();
            }
            else if (currentTemperatrue == desiredTemperature)
            {
                hvac.Off();
            }
            else if (currentTemperatrue > desiredTemperature)
            {
                hvac.Cool();
            }

        }
    }
}

