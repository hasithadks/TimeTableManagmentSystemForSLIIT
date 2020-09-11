using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayers.Student
{
    public class StudentModel
    {
        public string studentId { set; get; }

        public string academicYearSemester { set; get; }

        public string programme { set; get; }

        public int groupNumber { set; get; }

        public string groupId { set; get; }

        public int subGroupNumber { set; get; }

        public string subGroupId { set; get; }


        public StudentModel() {

            this.studentId = string.Empty;
            this.academicYearSemester = string.Empty;
            this.programme = string.Empty;
            this.groupNumber = 0;
            this.groupId = string.Empty;
            this.subGroupNumber = 0;
            this.subGroupId = string.Empty;
        }


        public StudentModel(string StudentId, string AcademicYearSemester, string Programme, int GroupNumber, string GroupId,int SubGroupNumber,string SubGroupId)
        {
            this.studentId = StudentId;
            this.academicYearSemester = AcademicYearSemester;
            this.programme = Programme;
            this.groupNumber = GroupNumber;
            this.groupId = GroupId;
            this.subGroupNumber = SubGroupNumber;
            this.subGroupId = SubGroupId;
        }
    }
}
