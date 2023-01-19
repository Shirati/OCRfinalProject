using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.DTOs
{
    public class ActionDTO
    {
        public int ActionId { get; set; }

        public int? ActionTypeId { get; set; }

        public int? UserId { get; set; }

        public int? PaymentId { get; set; }

        public bool? IsSucceeded { get; set; }
    }
}
