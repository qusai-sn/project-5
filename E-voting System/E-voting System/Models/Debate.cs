//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_voting_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Debate
    {
        public int ID { get; set; }
        public Nullable<int> Circle_ID { get; set; }
        public Nullable<System.DateTime> Date_Of_Debate { get; set; }
        public string Topic { get; set; }
        public string First_Candidate { get; set; }
        public string First_Candidate_List { get; set; }
        public string Second_Candidate { get; set; }
        public string Second_Candidate_List { get; set; }
        public string Status { get; set; }
        public string Zoom_link { get; set; }
    }
}