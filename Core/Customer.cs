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
        [MaxLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        [NotMapped]
        IContactdata ICustomer.IContactdata => this.Contactdata;
        public Contactdata Contactdata { get; set; }


        #endregion

        #region Private Properties


        #endregion

        #region Public Methods

        //create a new Customer
        public void CreateCustomer(){}

        //find/get a specific Customer
        public void GetCustomer(){}

        //Update Customer information
        public void UpdateCustomer(){}

        //delete a Customer from the database
        public void DeleteCustomer() {}

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
