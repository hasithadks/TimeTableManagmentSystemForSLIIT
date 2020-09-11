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

        public string StudentID { set; get; }

        public int Group { set; get; }

        public int SubGroup { set; get; }

        public StatisticBO()
        {
            this.Year = "";
            this.Semester = "";
            this.Programme = "";
            this.AcadmicY_S = "";
            this.StudentID = "";
            this.Group = 0;
            this.SubGroup = 0;


        }
    }
}
