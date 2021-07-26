using ICore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Bill : IBill
    {
        [MaxLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Name { get; set; }
        public string BillId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //single relationship from Project to Customer
        [NotMapped]
        ICustomer IBill.ICustomer => (ICustomer)Customer;
        public Customer Customer { get; set; }

        public string CustomerId { get; set; }

        /// <summary>
        /// The statustype of a project
        /// (options: IsPaid, Pending, Overdue, WarnedOff, Incaso)
        /// default: "Pending"
        /// </summary>
        [NotMapped]
        public ProjectStatusType Status { get; set; } = ProjectStatusType.Pending;
    }
}
