using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMock.VS15.UnitTests.Mocks.Mocks
{
    class SensorMock : ISensor
    {
        public int CurrentTemperature = 0;

        public int Read()
        {
            return CurrentTemperature;
        }
    }
}

