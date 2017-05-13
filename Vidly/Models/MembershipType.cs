using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public int SignUpFee { get; set; }
        public int DurationInMonth { get; set; }
        public int DiscountRate { get; set; }
        public string Name { get; set; }

        public static readonly int Unknown = 0;
        public static readonly int PayAsYouGo = 9;
        public static readonly int Monthly = 10;
        public static readonly int Quaterly = 11;
        public static readonly int Anual = 12;
    }
}