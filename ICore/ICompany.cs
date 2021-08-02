using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICore
{
    /// <summary>
    /// describes the Company
    /// </summary>
    public interface ICompany
    {

        #region Public Properties

        /// <summary>
        /// unique id for the company
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// path of the company-logo
        /// </summary>
        public string Logo { get; }

        /// <summary>
        /// Name of the company
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// paymentridge of the company
        /// </summary>
        public int PaymentRidge { get; }

        /// <summary>
        /// Contactdata of the company
        /// </summary>
        public IContactdata IContactdata { get; }

        /// <summary>
        /// The contactdataId of the company
        /// </summary>
        public string ContactdataId { get; }

        /// <summary>
        /// users from the company""
        /// </summary>
        public IEnumerable<IUser> IUsers { get; }

        #endregion

        #region Private Properties



        #endregion

        #region Public Methods

        //create a new Company
        public void CreateCompany(string logo, string name, int paymentRidge, IContactdata iContactdata, IUser iUsers);

        //find/get a specific Company
        public void GetCompany(string id);

        //Update Company information
        public void UpdateCompany(string logo, int paymentRidge, IContactdata iContactdata, IUser iUsers);

        //delete a Company from the database
        public void DeleteCompany();

        #endregion

        #region Private Methods



        #endregion

        #region Constructor



        #endregion
    }
}
