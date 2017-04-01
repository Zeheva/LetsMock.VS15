using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMock.VS15
{
    public class Dashboard : IDashboard
    {
        public Dashboard()
        {
        }

        public int GetDesiredTemperature()
        {
            return 72;
        }
    }
}