using ICore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Project : IProject
    {

        #region Public Properties

        /// <summary>
        /// The Unique ID of the Project
        /// </summary>
        [Key]
        [MaxLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// The name of the project 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The Date when the project was created
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The Date when the project was updated
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// the id of the associated bill
        /// </summary>
        public string BillId { get; set; }

        /// <summary>
        /// the associated bill
        /// </summary>
        [NotMapped]
        public IBill IBill => Bill;

        [ForeignKey("BillId")]
        public Bill Bill { get; set; }

        /// <summary>
        /// The startdate of the project
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The enddate of the project
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The associated Customer of the project
        /// </summary>
        [NotMapped]
        public ICustomer ICustomer => Customer;
        public Customer Customer { get; set; }
        public string CustomerId { get; set; }

        ///// <summary>
        ///// the users of the project
        ///// </summary>
        [NotMapped]
        IEnumerable<IUser> IProject.IUsers => this.Users;
        public List<User> Users { get; set; } = new List<User>();

        /// <summary>
        /// the project status
        /// </summary>
        [NotMapped]
        public string Status { get; set; } = "pending";

        /// <summary>
        /// The name of the street of the project location
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// The Town of the project location
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// The ZipCode of the project-adress
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// describes the country of the project
        /// </summary>
        public string Country { get; set; }

        #endregion

        #region Private Properties


        #endregion

        #region Public Methods
        //print the Bill
        public void PrintBill() { }

        //add an article to the project
        public void AddArticle() { }

        //Delete an article from the project
        public void DeleteArticle() { }

        #endregion

        #region Private Methods


        #endregion

        #region Constructor

        public Project()
        {

        }


        #endregion


    }
}
