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
    public class Company : ICompany
    {

        #region Public Properties

        /// <summary>
        /// unique id for the company
        /// </summary>
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// path of the company-logo
        /// </summary>
        public string Logo { get; set; }

        /// <summary>
        /// Name of the company
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// paymentridge of the company
        /// </summary>
        public int PaymentRidge { get; set; }

        /// <summary>
        /// Contactdata of the company
        /// </summary>
        [NotMapped]
        IContactdata ICompany.IContactdata => this.Contactdata;
        public Contactdata Contactdata { get; set; }

        /// <summary>
        /// user from the company""
        /// </summary>
        [NotMapped]
        public IEnumerable<IUser> IUsers => this.Users;
        public IEnumerable<User> Users { get; set; }

        #endregion

        #region Private Properties


        #endregion

        #region Public Methods


        //create a new Company
        public void CreateCompany(string logo, string name, int paymentRidge, IContactdata iContactdata, IUser iUsers) { }

        //find/get a specific Company
        public void GetCompany(string id) { }

        //Update Company information
        public void UpdateCompany(string logo, int paymentRidge, IContactdata iContactdata, IUser iUsers) { }

        //delete a Company from the database
        public void DeleteCompany() { }
        #endregion

        #region Private Methods


        #endregion

        #region Constructor

        public Company()
        {

        }

        #endregion



    }
}
