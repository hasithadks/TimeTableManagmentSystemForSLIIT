using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayers.Subject
{
    class SubjectData
    {
        public int SaveSubjectData(string specialized, string scode,string sname,int offyear,int offsemester,int lechours,int tuthours,int labhours,int evahours)
        {
            int id = 0;

            using (var context = new TimetableManagementSystemEntities2())
            {
                //insert
                DataLayer.Subject subject = new DataLayer.Subject()
                {
                    sCode = scode,
                    sName = sname,
                    offYear = offyear,
                    offSemester = offsemester,
                    lecHours = lechours,
                    tutHours = tuthours,
                    labHours = labhours,
                    evaHours = evahours,
                    specialization = specialized
                };
                context.Subjects.Add(subject);
                context.SaveChanges();

                id = subject.id;
            }
            return id;
        }

        public List<DataLayer.Subject> GetAllSubjectsData()
        {
            using (var context = new TimetableManagementSystemEntities2())
            {
                //View
                List<DataLayer.Subject> multiple = context.Subjects.ToList();
                return multiple;
            }
        }

        public void UpdateSubjectData(SubjectClass subject)
        {
            using (var context = new TimetableManagementSystemEntities2())
            {
                var updateSubject = context.Subjects.Where(p => p.id == subject.id).FirstOrDefault();

                //update
                //if (updateSubject != null)
                //{
                //updateSubject.id = subject.id;
                    updateSubject.sCode = subject.sCode;
                    updateSubject.sName = subject.sName;
                    updateSubject.offYear = subject.offYear;
                    updateSubject.offSemester = subject.offSemester;
                    updateSubject.lecHours = subject.lecHours;
                    updateSubject.tutHours = subject.tutHours;
                    updateSubject.labHours = subject.labHours;
                    updateSubject.evaHours = subject.evaHours;

                    context.SaveChanges();
                //}
                
            }
        }

        public void DeleteSubjectData(SubjectClass subject)
        {
            using (var context = new TimetableManagementSystemEntities2())
            {
                //delete
                var DeleteSubject = context.Subjects.Where(p => p.id == subject.id).FirstOrDefault();

                //if (DeleteSubject != null)
                //{
                    context.Subjects.Remove(DeleteSubject);
                    context.SaveChanges();
                //}
            }
        }

        public List<DataLayer.Subject> getAllSubjectsMatchToYearAndSem(int year, int sem)
        {
            using (var context = new TimetableManagementSystemEntities2())
            {
                //View
                List<DataLayer.Subject> multiple = context.Subjects.Where(q => q.offYear == year && q.offSemester == sem).ToList();
                return multiple;
            }
        }
    }
}
