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
    public class Contactdata : IContactdata
    {

        #region Public Properties

        /// <summary>
        /// the id of the contactdata
        /// </summary>
        [Key]
        [MaxLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// the address object of the contactdata
        /// </summary>
        [NotMapped]
        IAddress IContactdata.IAddress => this.Address;
        public Address Address { get; set; }

        /// <summary>
        /// the phonenumber of the contactdata
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// the mobilenumber of the contactdata
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// the email of the conatctdata
        /// </summary>
        public string Email { get; set; }

        #endregion

        #region Private Properties


        #endregion

        #region Public Methods


        #endregion

        #region Private Methods


        #endregion

        #region Constructor

        public Contactdata()
        {

        }

        #endregion


    }
}
