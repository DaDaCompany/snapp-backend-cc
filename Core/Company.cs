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
        [Key]
        [MaxLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// path of the company-logo
        /// </summary>
        /// [MaxLength(36)]
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
        public IContactdata IContactdata => Contactdata;
        public Contactdata Contactdata { get; set; }

        /// <summary>
        /// The contactdataId of the company
        /// </summary>
        public string ContactdataId { get; set; }

        /// <summary>
        /// userlist from the company""
        /// </summary>
        [NotMapped]
        IEnumerable<IUser> ICompany.IUsers => this.Users;
        public List<User> Users { get; set; } = new List<User>();


        /// <summary>
        /// user from the company""
        /// </summary>
        //[NotMapped]
        //public IUser IUser => User;
        //public User User { get; set; }

        ///// <summary>
        ///// Project ID in which the article is used
        ///// </summary>
        //public IProject IProject { get; } /// needs the company a list of projects?

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
