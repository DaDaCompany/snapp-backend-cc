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
        [MaxLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Logo { get; set; }
        public string Name { get; set; }
        public int PaymentRidge { get; set; }


        [NotMapped]
        IContactdata ICompany.IContactdata => this.Contactdata;
        public Contactdata Contactdata { get; set; }

        [NotMapped]
        IUser ICompany.IUsers => this.Users;
        public User Users { get; set; }

        #endregion

        #region Private Properties


        #endregion

        #region Public Methods


        //create a new Company
        public void CreateCompany(string logo, string name, int paymentRidge, IContactdata iContactdata, IUser iUsers) { }

        //find/get a specific Company
        public void GetCompany(string id){}

        //Update Company information
        public void UpdateCompany(string logo, int paymentRidge, IContactdata iContactdata, IUser iUsers){}

        //delete a Company from the database
        public void DeleteCompany(){}
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
