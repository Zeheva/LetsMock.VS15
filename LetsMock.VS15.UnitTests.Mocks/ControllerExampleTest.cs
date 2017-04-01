using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMock.VS15.UnitTests.Mocks
{
    class ControllerExampleTest
    {
        public void ExecuteWithOrginalClasses()
        {
            var controller = new Controller(new Dashboard(), new Sensor(), new HVAC());
            controller.Execute();
        }
    }
}
