//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestAPI.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmailRequest
    {
        public int Id { get; set; }
        public string Request { get; set; }
        public Nullable<bool> Status { get; set; }
        public string Maker { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
