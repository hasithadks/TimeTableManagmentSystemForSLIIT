using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayers.Subject
{
    public class SubjectController
    {
        private SubjectData subjectData;

        public int saveSubject(string scode, string sname, int offyear, int offsemester, int lechours, int tuthours, int labhours, int evahours) 
        {
            subjectData = new SubjectData();
            int id = subjectData.SaveSubjectData(scode,sname,offyear,offsemester,lechours,tuthours,labhours,evahours);

            return id;
        }

        public List<DataLayer.Subject> getAllSubjects()
        {
            subjectData = new SubjectData();
            return subjectData.GetAllSubjectsData();
        }

        public void updateStudent(SubjectClass subject)
        {
            subjectData = new SubjectData();
            subjectData.UpdateSubjectData(subject);
        }

        public void deleteStudent(SubjectClass subject)
        {
            subjectData = new SubjectData();
            subjectData.DeleteSubjectData(subject);
        }

        public List<DataLayer.Subject> getAllSubjectsMatchToYearAndSem(int year, int sem)
        {
            subjectData = new SubjectData();
            return subjectData.getAllSubjectsMatchToYearAndSem(year, sem);
        }
    }
}
