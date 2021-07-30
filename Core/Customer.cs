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
    public class Customer : ICustomer
    {

        #region Public Properties

        /// <summary>
        /// unique id of the contactdata
        /// </summary>
        [Key]
        [MaxLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// Firstname of the Customer
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// Lastname of the Customer
        /// </summary>
        public string Lastname { get; set; }

        /// <summary>
        /// The contactdata of the customer
        /// </summary>
        [NotMapped]
        IContactdata ICustomer.IContactdata => this.Contactdata;
        public Contactdata Contactdata { get; set; }

        /// <summary>
        /// Project ID in which the article is used
        /// </summary>
        [NotMapped]
        IEnumerable<IProject> ICustomer.IProjects => this.Projects;
        public List<Project> Projects { get; set; } = new List<Project>();

        //[NotMapped]
        //public IProject IProject => this.Project;
        //public Project Project { get; set; }

        #endregion

        #region Private Properties


        #endregion

        #region Public Methods

        //create a new Customer
        public void CreateCustomer() { }

        //find/get a specific Customer
        public void GetCustomer() { }

        //Update Customer information
        public void UpdateCustomer() { }

        //delete a Customer from the database
        public void DeleteCustomer() { }

        #endregion

        #region Private Methods


        #endregion

        #region Constructor

        public Customer()
        {

        }

        #endregion



    }
}
