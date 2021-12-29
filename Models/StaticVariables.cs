using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPI.Models
{
    public class StaticVariables
    {
        public static string FAILEDMESSAGE { get; set; } = "Failed to Insert Record";
        public static string SUCCESSSTATUS { get; set; } = "Success";
        public static string SUCCESSMESSAGE { get; set; } = "Request Successful";
        public static string FAILEDTATUS { get; set; } = "Failed";
    }
}