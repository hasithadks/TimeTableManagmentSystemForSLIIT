using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayers.Lecturer
{
    public class LecturerClass
    {
        public int id { set; get; }

        public string lID { set; get; }

        public string lName { set; get; }

        public string lFaculty { set; get; }

        public string lDepartment { set; get; }

        public string lCenter { set; get; }

        public string lBuilding { set; get; }

        public int lLevel { set; get; }

        public string lRank { set; get; }

        public LecturerClass(int id,string lid, string lname, string lfaculty, string ldepartment, string lcenter, string lbuilding, int llevel, string lrank)
        {
            this.id = id;
            this.lID = lid;
            this.lName = lname;
            this.lFaculty = lfaculty;
            this.lDepartment = ldepartment;
            this.lCenter = lcenter;
            this.lBuilding = lbuilding;
            this.lLevel = llevel;
            this.lRank = lrank;
        }

        public LecturerClass()
        {
            this.id = 0;
            this.lID = "";
            this.lName = "";
            this.lFaculty = "";
            this.lDepartment = "";
            this.lCenter = "";
            this.lBuilding = "";
            this.lLevel = 0;
            this.lRank = "";

        }
    }
}
