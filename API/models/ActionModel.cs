using System.ComponentModel.DataAnnotations;

namespace API.models
{
    public class ActionModel
    {
        public int ActionId { get; set; }

        public int? ActionTypeId { get; set; }

        public int? UserId { get; set; }

        public int? PaymentId { get; set; }

        public bool? IsSucceeded { get; set; }
    }
}
