//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class test
    {
        public int test_id { get; set; }
        public string username { get; set; }
        public int client_id { get; set; }
        public string test_date { get; set; }
        public Nullable<int> max_hr { get; set; }
        public Nullable<int> max_hr_50 { get; set; }
        public Nullable<int> max_hr_80 { get; set; }
        public Nullable<decimal> ac { get; set; }
        public string fitnessrating { get; set; }
        public int test_number { get; set; }
        public string notes { get; set; }
    
        public virtual client client { get; set; }
        public virtual staff1 staff { get; set; }
    }
}
