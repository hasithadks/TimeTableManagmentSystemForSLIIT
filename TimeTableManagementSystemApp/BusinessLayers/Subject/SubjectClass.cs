using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayers.Subject
{
    public class SubjectClass
    {
        public int id { set; get; }

        public string sCode { set; get; }

        public string sName { set; get; }

        public int offYear { set; get; }

        public int offSemester { set; get; }

        public int lecHours { set; get; }

        public int tutHours { set; get; }

        public int labHours { set; get; }

        public int evaHours { set; get; }

        public SubjectClass(int id,string sCode,string sName,int offYear,int offSemester,int lecHours,int tutHours,int labHours,int evaHours)
        {
            this.id = id;
            this.sCode = sCode;
            this.sName = sName;
            this.offYear = offYear;
            this.offSemester = offSemester;
            this.lecHours = lecHours;
            this.tutHours = tutHours;
            this.labHours = labHours;
            this.evaHours = evaHours;
        }
    }
}
