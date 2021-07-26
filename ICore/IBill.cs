using ICore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICore
{
    public interface IBill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(36)]
        public string Id { get; }
        public DateTime CreatedAt { get; }
        public DateTime UpdatedAt { get; }
        public string Name { get; }
        public string BillId { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }

        //single relationship from Project to Customer
        [NotMapped]
        public ICustomer ICustomer { get; }

        /// <summary>
        /// The statustype of a project
        /// (options: IsPaid, Pending, Overdue, WarnedOff, Incaso)
        /// default: "Pending"
        /// </summary>
        [NotMapped]
        public ProjectStatusType Status { get; }
    }
}
