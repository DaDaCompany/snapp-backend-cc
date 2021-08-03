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
        /// <summary>
        /// The id of the Bill
        /// </summary>
        [Key]
        [MaxLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// the name of the project for the bill
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// the start date of the project
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// the enddate of the project for the bill
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// the customer of the project for the bill
        /// </summary>
        [NotMapped]
        public ICustomer ICustomer => Customer;
        public Customer Customer { get; set; }

        /// <summary>
        /// describes the id of the customer
        /// </summary>
        public string CustomerId { get; set; }

        ///article history List for the positions (articles) on the bill 

        /// <summary>
        /// the costs without taxes
        /// </summary>
        public double NetCost { get; set; }

        /// <summary>
        /// the costs with taxes
        /// </summary>
        public double TotalCost { get; set; }

        public string ProjectId { get; set; }

        /// <summary>
        /// the number of the Bill
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public static int BillNumber { get; set; }

    }
}
