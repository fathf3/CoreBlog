using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message 
    {
        [Key]
        public int messageId { get; set; }
        public string sender { get; set; } 
        public string receiver { get; set; } 
        public string subject { get; set; } 
        public string messageDetails { get; set; } 
        public DateTime messageDate { get; set; } 
        public bool messageStatus { get; set; } 
    }
}
