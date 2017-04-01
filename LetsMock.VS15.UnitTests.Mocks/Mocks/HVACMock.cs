using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMock.VS15.UnitTests.Mocks.Mocks
{
    public class HVACMock : IHVAC
    {
        public enum Mode
        {
            Cool,
            Heat,
            Off
        }

        internal List<Mode> History = new List<Mode>();

        public void Cool()
        {
            History.Add(Mode.Cool);
        }

        public void Heat()
        {
            History.Add(Mode.Heat);
        }

        public void Off()
        {
            History.Add(Mode.Off);
        }
    }
}
