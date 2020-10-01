using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayers.TimeSessions
{
    class SessionData
    {

        public int CreateSession(SessionBO sessionBO)
        {
            using (var context = new TimetableManagementSystemEntities2())
            {
                TimeSession timeSession = new TimeSession()
                {
                    sYear = sessionBO.sYear,
                    sSem = sessionBO.sSem,
                    sLecturer01 = sessionBO.sLecturer01,
                    sLecturer02 = sessionBO.sLecturer02 == "" ? null : sessionBO.sLecturer02,
                    sLecturer03 = sessionBO.sLecturer03 == "" ? null : sessionBO.sLecturer03,
                    sLecturer04 = sessionBO.sLecturer04 == "" ? null : sessionBO.sLecturer04,
                    sSubject = sessionBO.sSubject,
                    sSubjectCode = sessionBO.sSubjectCode,
                    sGroup = sessionBO.sGroup,
                    sSubGroup = sessionBO.sSubGroup,
                    sTag = sessionBO.sTag,
                    sNoOfStudents = sessionBO.sNoOfStudent,
                    sSessionDuration = sessionBO.sSessionDuration,
                    sIsConsecutive = 0,
                    sConsecutiveSessionID = 0,
                    RoomID = 0,
                    RoomName = ""

                };
              

                context.TimeSessions.Add(timeSession);
                context.SaveChanges();


                return timeSession.id;
            }

        }

        public int UpdateSession(int sessionID, int RoomID, String RoomName)
        {
            using (var context = new TimetableManagementSystemEntities2())
            {

                var updateTimeSession = context.TimeSessions.Where(p => p.id == sessionID).FirstOrDefault();

                if(updateTimeSession != null)
                {
                    updateTimeSession.RoomID = RoomID;
                    updateTimeSession.RoomName = RoomName;

                    context.SaveChanges();
                }

              

                return updateTimeSession.id;
            }

        }

        public List<TimeSession> GetTimeSessions()
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<TimeSession> multiple = context.TimeSessions.ToList();


                return multiple;
            }


        }

        public TimeSession GetDeleteSession(int sessionID)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                return context.TimeSessions.Where(q => q.id == sessionID).FirstOrDefault();

                
            }


        }

        public int DeleteSession(int sessionID, int? concecativeSessionID)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                //Delete Session
                var deletingSession = context.TimeSessions.Where(q => q.id == sessionID).FirstOrDefault();

                if (deletingSession != null)
                {

                    if(concecativeSessionID > 0)
                    {
                        var deletingSession02 = context.TimeSessions.Where(q => q.id == concecativeSessionID).FirstOrDefault();

                        if(deletingSession02 != null)
                        {
                            context.TimeSessions.Remove(deletingSession02);
                            context.SaveChanges();
                        }
                        
                    }

                    context.TimeSessions.Remove(deletingSession);
                    context.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }


            }


        }


        public List<TimeSession> GetLocationNotAddedTimeSessions()
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                  List<TimeSession> multiple = context.TimeSessions.Where(q => q.RoomID == null || q.RoomID == 0).ToList();


                   return multiple;
            }


        }

        public List<TimeSession> GetLocationAddedTimeSessions()
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<TimeSession> multiple = context.TimeSessions.Where(q =>  q.RoomID > 0).ToList();


                return multiple;
            }


        }


        public List<TimeSession> GetTimeSessionsAssignLecturer(string LecName)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<TimeSession> multiple = context.TimeSessions.Where(q => q.sLecturer01 == LecName || 
                                                                             q.sLecturer02 == LecName ||
                                                                             q.sLecturer03 == LecName ||
                                                                             q.sLecturer04 == LecName ).ToList();


                return multiple;
            }


        }

        public List<TimeSession> GetTimeSessionsAssignLecturerNotListed(string LecName)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<TimeSession> multiple = context.TimeSessions.Where(q => (q.sLecturer01 == LecName ||
                                                                             q.sLecturer02 == LecName ||
                                                                             q.sLecturer03 == LecName ||
                                                                             q.sLecturer04 == LecName) && q.RoomID == 0).ToList();


                return multiple;
            }


        }

        public List<TimeSession> GetTimeSessionsAssignLecturerListed(string LecName)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<TimeSession> multiple = context.TimeSessions.Where(q => (q.sLecturer01 == LecName ||
                                                                             q.sLecturer02 == LecName ||
                                                                             q.sLecturer03 == LecName ||
                                                                             q.sLecturer04 == LecName) && q.RoomID > 0).ToList();


                return multiple;
            }


        }
        public List<TimeSession> GetTimeSessionsAssignSubject(string subject)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<TimeSession> multiple = context.TimeSessions.Where(q => q.sSubject == subject).ToList();


                return multiple;
            }


        }

        public List<TimeSession> GetTimeSessionsAssignSubjectNotListed(string subject)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<TimeSession> multiple = context.TimeSessions.Where(q => q.sSubject == subject && q.RoomID == 0).ToList();


                return multiple;
            }


        }

        public List<TimeSession> GetTimeSessionsAssignSubjectListed(string subject)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<TimeSession> multiple = context.TimeSessions.Where(q => q.sSubject == subject && q.RoomID > 0).ToList();


                return multiple;
            }


        }

        public List<TimeSession> GetTimeSessionsAssignGroup(string Group)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<TimeSession> multiple = context.TimeSessions.Where(q => q.sGroup == Group).ToList();


                return multiple;
            }


        }

        public List<TimeSession> GetTimeSessionsAssignGroupNotListed(string Group)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<TimeSession> multiple = context.TimeSessions.Where(q => q.sGroup == Group && q.RoomID == 0).ToList();


                return multiple;
            }


        }

        public List<TimeSession> GetTimeSessionsAssignGroupListed(string Group)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<TimeSession> multiple = context.TimeSessions.Where(q => q.sGroup == Group && q.RoomID > 0).ToList();


                return multiple;
            }


        }

        public int Createconsecutivesessions(int session01, int ssession02)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                //update
                var updatingSession = context.TimeSessions.Where(q => q.id == session01).FirstOrDefault();

                if (updatingSession != null)
                {
                    updatingSession.sConsecutiveSessionID = ssession02;
                    context.SaveChanges();
                    
                }
                else
                {
                    return 0;
                }

                var updatingSession02 = context.TimeSessions.Where(q => q.id == ssession02).FirstOrDefault();
                if (updatingSession02 != null)
                {
                    updatingSession02.sIsConsecutive = 1;
                    context.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }

            }


        }
    }
}
