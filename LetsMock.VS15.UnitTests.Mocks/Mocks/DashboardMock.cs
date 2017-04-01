using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMock.VS15.UnitTests.Mocks.Mocks
{
    class DashboardMock : IDashboard
    {
        internal int DesiredTemperature = 0;

        public int GetDesiredTemperature()
        {
            return DesiredTemperature;
        }
    }
}
