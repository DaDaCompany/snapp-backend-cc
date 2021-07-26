using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICore
{
    /// <summary>
    /// describes the PaymentInformation
    /// </summary>
    public interface IPaymentInformation
    {

        #region Public Properties

        /// <summary>
        /// unique id of the paymentinformation
        /// </summary>
        public string Id { get;  }

        /// <summary>
        /// the name of the bank
        /// </summary>
        public string Bankname { get;  }

        /// <summary>
        /// The name of the owner from the Bankaccount
        /// </summary>
        public string BankAccountOwner { get;  }

        /// <summary>
        /// the international bankaccountnumber
        /// </summary>
        public string IBAN { get;  }

        /// <summary>
        /// the Bank Identifier Code
        /// </summary>
        public string BIC { get;  }

        /// <summary>
        /// the VAT-Number
        /// </summary>
        public string VatNumber { get;  }

        #endregion

        #region Private Properties


        #endregion

        #region Public Methods


        #endregion

        #region Private Methods


        #endregion

        #region Constructor


        #endregion


    }
}
