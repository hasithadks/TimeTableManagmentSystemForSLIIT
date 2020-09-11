using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace BusinessLayers.Student
{
    public class StudentData
    {
        public void InsertStudentToDatabase(StudentModel student)
        {
            using (var context = new TimetableManagementSystemEntities2())
            {

                //insert
               StudentDetail newStudent = new StudentDetail()
                {
                   StudentId = student.studentId,
                   AcademicYearSemester = student.academicYearSemester,
                   Programme = student.programme,
                   GroupNumber =student.groupNumber,
                   GroupId =student.groupId,
                   SubGroupNumber =student.subGroupNumber,
                   SubGroupId =student.subGroupId

               };
                    context.StudentDetails.Add(newStudent);
                    context.SaveChanges();
            }
          
        }
        public List<DataLayer.StudentDetail> GetAllStudents()
        {
            using (var context = new TimetableManagementSystemEntities2())
            {
                List<DataLayer.StudentDetail> multiple = context.StudentDetails.ToList();

                return multiple;
            }


        }

        public void UpdateStudentInDatabase(StudentModel studentModel)
        {
            using (var context = new TimetableManagementSystemEntities2())
            {
                //update
                var updatingStudent = context.StudentDetails.Where(p => p.StudentId == studentModel.studentId).FirstOrDefault();

                if (updatingStudent != null)
                {
                    updatingStudent.StudentId = studentModel.studentId;
                    updatingStudent.AcademicYearSemester = studentModel.academicYearSemester;
                    updatingStudent.Programme = studentModel.programme;
                    updatingStudent.GroupNumber = studentModel.groupNumber;
                    updatingStudent.GroupId = studentModel.groupId;
                    updatingStudent.SubGroupNumber = studentModel.subGroupNumber;
                    updatingStudent.SubGroupId = studentModel.subGroupId;

                    context.SaveChanges();
                }
               
            }
        }
        
        public void DeleteStudentDetailsInDatabase(StudentModel studentModel)
        {
            using (var context = new TimetableManagementSystemEntities2())
            {
                //delete
                var DeleteStudent = context.StudentDetails.Where(p => p.StudentId == studentModel.studentId).FirstOrDefault();

                if (DeleteStudent != null)
                {
                    context.StudentDetails.Remove(DeleteStudent);
                    context.SaveChanges();
                }
                
            }
        }
    }
}
