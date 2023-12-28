using System.ComponentModel.DataAnnotations;

namespace CsharpWorkshop.Models;
public class TicketClass
    {
        [Key]
        public int SWORDER_NO { get; private set; }
        public int SWORDER_DATE { get; set; }
        public string SWORDER_TIME { get; set; } // Assuming this is a time represented as a string
        public int SWORDER_ARNO { get; set; }
        public string SWORDER_NAME { get; set; }
        public string SWORDER_APPL { get; set; }
        public string SWORDER_REPORTED_BY { get; set; }
        public int SWORDER_CHARGE { get; set; }
        public int SWORDER_PONO { get; set; }
        public string SWORDER_DESC { get; set; }
        public string SWORDER_TYPE { get; set; }
        public string SWORDER_ASSIGNTO { get; set; }
        public string SWORDER_STATUS { get; set; }
        public string SWORDER_SOLUTION { get; set; }
        public string SWORDER_SOL_DATE { get; set; } // Assuming this is a date represented as a string
        public string SWORDER_SOL_TIME { get; set; } // Assuming this is a time represented as a string
        public string SWORDER_ADDED_BY { get; set; }
        public string SWORDER_PROG_NAME { get; set; }
        public int SWORDER_DATE_SENT { get; set; }
        public string SWORDER_WHO_CLOSED { get; set; }
        public int SWORDER_CLASS { get; set; }
        public string SWORDER_DOC_GUID { get; set; }
        public int SWORDER_CHARGE_HRS { get; set; }
        public int SWORDER_NO_CHG_HRS { get; set; }
        public int SWORDER_APP_MAINT { get; set; }
    }
