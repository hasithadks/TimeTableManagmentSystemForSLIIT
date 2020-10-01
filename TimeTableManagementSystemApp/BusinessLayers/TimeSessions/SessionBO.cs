using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayers.TimeSessions
{
    public class SessionBO
    {

        public int SessionID { set; get; }
        public int sYear { set; get; }
        public int sSem { set; get; }

        public string sLecturer01 { set; get; }
        public string sLecturer02 { set; get; }
        public string sLecturer03 { set; get; }
        public string sLecturer04 { set; get; }
        public string sSubject { set; get; }
        public string sSubjectCode { set; get; }
        public string sGroup { set; get; }
        public string sSubGroup { set; get; }
        public string sTag { set; get; }

        public int sNoOfStudent { set; get; }
        public int sSessionDuration { set; get; }
        public bool sIsConsecutive { set; get; }
        public int sConsecutiveSessionID { set; get; }


    }
}
