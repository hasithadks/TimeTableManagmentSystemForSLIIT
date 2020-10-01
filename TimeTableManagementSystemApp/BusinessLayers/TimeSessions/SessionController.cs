using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayers.TimeSessions
{
    public class SessionController
    {

        public int CreateSession(SessionBO sessionBO)
        {
            SessionData sessionData = new SessionData();
            return sessionData.CreateSession(sessionBO);

        }

        public int UpdateSession(int sessionID, int RoomID, String RoomName)
        {
            SessionData sessionData = new SessionData();
            return sessionData.UpdateSession(sessionID, RoomID, RoomName);

        }

        public List<TimeSession> GetTimeSessions()
        {
            SessionData sessionData = new SessionData();
            return sessionData.GetTimeSessions();
        }

        public List<TimeSession> GetLocationNotAddedTimeSessions()
        {
            SessionData sessionData = new SessionData();
            return sessionData.GetLocationNotAddedTimeSessions();
        }

        public List<TimeSession> GetLocationAddedTimeSessions()
        {
            SessionData sessionData = new SessionData();
            return sessionData.GetLocationAddedTimeSessions();
        }

        public int Createconsecutivesessions(int session01, int ssession02)
        {

            SessionData sessionData = new SessionData();
            return sessionData.Createconsecutivesessions(session01, ssession02);
        }

        
        public List<TimeSession> GetTimeSessionsAssignLecturer(string lecName)
        {
            SessionData sessionData = new SessionData();
            return sessionData.GetTimeSessionsAssignLecturer(lecName);
        }

        public List<TimeSession> GetTimeSessionsAssignLecturerNotListed(string lecName)
        {
            SessionData sessionData = new SessionData();
            return sessionData.GetTimeSessionsAssignLecturerNotListed(lecName);
        }
        public List<TimeSession> GetTimeSessionsAssignLecturerListed(string lecName)
        {
            SessionData sessionData = new SessionData();
            return sessionData.GetTimeSessionsAssignLecturerListed(lecName);
        }
        public List<TimeSession> GetTimeSessionsAssignSubject(string subject)
        {
            SessionData sessionData = new SessionData();
            return sessionData.GetTimeSessionsAssignSubject(subject);
        }

        public List<TimeSession> GetTimeSessionsAssignSubjectNotListed(string subject)
        {
            SessionData sessionData = new SessionData();
            return sessionData.GetTimeSessionsAssignSubjectNotListed(subject);
        }

        public List<TimeSession> GetTimeSessionsAssignSubjectListed(string subject)
        {
            SessionData sessionData = new SessionData();
            return sessionData.GetTimeSessionsAssignSubjectListed(subject);
        }

        public List<TimeSession> GetTimeSessionsAssignGroup(string group)
        {
            SessionData sessionData = new SessionData();
            return sessionData.GetTimeSessionsAssignGroup(group);
        }

        public List<TimeSession> GetTimeSessionsAssignGroupNotListed(string group)
        {
            SessionData sessionData = new SessionData();
            return sessionData.GetTimeSessionsAssignGroupNotListed(group);
        }

        public List<TimeSession> GetTimeSessionsAssignGroupListed(string group)
        {
            SessionData sessionData = new SessionData();
            return sessionData.GetTimeSessionsAssignGroupListed(group);
        }

        public TimeSession GetDeleteSession(int sessionID)
        {
            SessionData sessionData = new SessionData();
            return sessionData.GetDeleteSession(sessionID);
        }

        public int DeleteSession(int sessionID, int? concecativeSessionID)
        {
            SessionData sessionData = new SessionData();
            return sessionData.DeleteSession(sessionID, concecativeSessionID);
        }
    }
}
