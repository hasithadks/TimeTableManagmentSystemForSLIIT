//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class TimeSession
    {
        public int id { get; set; }
        public Nullable<int> sYear { get; set; }
        public Nullable<int> sSem { get; set; }
        public string sLecturer01 { get; set; }
        public string sLecturer02 { get; set; }
        public string sLecturer03 { get; set; }
        public string sLecturer04 { get; set; }
        public string sSubject { get; set; }
        public string sSubjectCode { get; set; }
        public string sGroup { get; set; }
        public string sSubGroup { get; set; }
        public string sTag { get; set; }
        public Nullable<int> sNoOfStudents { get; set; }
        public Nullable<int> sSessionDuration { get; set; }
        public Nullable<int> sIsConsecutive { get; set; }
        public Nullable<int> sConsecutiveSessionID { get; set; }
        public Nullable<int> RoomID { get; set; }
        public string RoomName { get; set; }
    }
}
