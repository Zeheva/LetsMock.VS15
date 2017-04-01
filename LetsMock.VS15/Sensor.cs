using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMock.VS15
{
    public class Sensor : ISensor
    {
        public Sensor()
        {
        }

        public int Read()
        {
            return 72;
        }
    }
}