using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data.Entity;
using System.Windows.Forms;

namespace BusinessLayers.Student
{
    public class StudentController
    {
        private StudentData studentData;

        public void InsertStudent(StudentModel student)
        {
            studentData = new StudentData();
            studentData.InsertStudentToDatabase(student);
        }

        public List<DataLayer.StudentDetail> SelectAllStudents()
        {
            studentData = new StudentData();

            return studentData.GetAllStudents();
        }

        public void updateStudentDetails(StudentModel student)
        {
            studentData = new StudentData();
            studentData.UpdateStudentInDatabase(student);
        }

        
        public void deleteStudentDetails(StudentModel student)
        {
            studentData = new StudentData();
            studentData.DeleteStudentDetailsInDatabase(student);
        }
    }
}
