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
    
    public partial class WorkingDay
    {
        public int WorkingDayID { get; set; }
        public string workingdayGroup { get; set; }
        public Nullable<int> workingdayYear { get; set; }
        public Nullable<int> workingdaySemester { get; set; }
        public string workingday1 { get; set; }
        public string workingday2 { get; set; }
        public string workingday3 { get; set; }
        public string workingday4 { get; set; }
        public string workingday5 { get; set; }
        public string workingday6 { get; set; }
        public string workingday7 { get; set; }
        public Nullable<int> workingdayOneHourTimeSlots { get; set; }
        public Nullable<int> ThirtyMinutesTimeSlots { get; set; }
    }
}