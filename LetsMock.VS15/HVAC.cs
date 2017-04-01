using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMock.VS15
{
    public class HVAC : IHVAC
    {
        private string status = "Off";


        public string GetStatus()
        {
            return status;
        }
        public void Heat()
        {
            status = "Heating";
        }

        public void Off()
        {
            status = "Off";
        }

        public void Cool()
        {
            status = "Colling";
        }
    }
}
