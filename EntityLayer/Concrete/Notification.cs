using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Notification
    {
        [Key]
        public int notificationId { get; set; }
        public string notificationType { get; set; }
        public string notificationTypeSymbol { get; set; }
        public string notificationDetails { get; set; }
        public DateTime notificationDate { get; set; }
        public bool notificationStatus { get; set; }
        
    }
}
