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
        /// <summary>
        /// The id of the Bill
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(36)]
        public string Id { get; }

        /// <summary>
        /// the name of the project for the bill
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// the start date of the project
        /// </summary>
        public DateTime StartDate { get; }

        /// <summary>
        /// the enddate of the project for the bill
        /// </summary>
        public DateTime EndDate { get; }

        /// <summary>
        /// the customer of the project for the bill
        /// </summary>
        public ICustomer ICustomer { get; }

        /// <summary>
        /// Project ID in which the article is used
        /// </summary>
        //public IProject IProject { get; }
    }
}
