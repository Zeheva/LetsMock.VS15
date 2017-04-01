using LetsMock.VS15.UnitTests.Mocks.Mocks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMock.VS15.UnitTests.Mocks
{

    public class ControllerTests
    {
        [Test]
        public void WhenCurrentTemperatureIsBelowDesiredTemp_TurnOnHeat()
        {
            var dashboard = new DashboardMock();
            var sensor = new SensorMock();
            var hvac = new HVACMock();

            var controller = new Controller(dashboard, sensor, hvac);

            dashboard.DesiredTemperature = 68;
            sensor.CurrentTemperature = 64;
            controller.Execute();

            var actualMode = hvac.History.Single();

           Assert.AreEqual(HVACMock.Mode.Heat, actualMode);


        }

        [Test]
        public void WhenCurrentTempIsAboveDesiredTemp_TurnOnCool()
        {
            var dashboard = new DashboardMock();
            var sensor = new SensorMock();
            var hvac = new HVACMock();

            var controller = new Controller(dashboard, sensor, hvac);

            dashboard.DesiredTemperature = 68;
            sensor.CurrentTemperature = 70;
            controller.Execute();

            var actualMode = hvac.History.Single();

            Assert.AreEqual(HVACMock.Mode.Cool, actualMode);

        }
        [TestCase(68, 64, HVACMock.Mode.Heat)]
        [TestCase(68, 68, HVACMock.Mode.Off)]
        [TestCase(68, 75, HVACMock.Mode.Cool)]
        public void ExecuteWithTemperaturesAndAssertMode(int desired, int current, HVACMock.Mode expectedMode)
        {
            var dashboard = new DashboardMock();
            var sensor = new SensorMock();
            var hvac = new HVACMock();
            var controller = new Controller(dashboard, sensor, hvac);
            dashboard.DesiredTemperature = desired;
            sensor.CurrentTemperature = current;
            controller.Execute();
            var actualMode = hvac.History.Single();
            Assert.AreEqual(expectedMode, actualMode);
        }

    }
}