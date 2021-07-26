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
        [MaxLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [NotMapped]
        IAddress IContactdata.IAddress => this.Address;
        public Address Address { get; set; }

        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
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
