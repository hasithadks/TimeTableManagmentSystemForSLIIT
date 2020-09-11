using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayers.StatisticF
{
    public class StatisticBO
    {
        public string Year { set; get; }

        public string Semester { set; get; }

        public string AcadmicY_S { set; get; }

        public string Programme { set; get; }



        public StatisticBO()
        {
            this.Year = "";
            this.Semester = "";
            this.Programme = "";
        }
    }
}
