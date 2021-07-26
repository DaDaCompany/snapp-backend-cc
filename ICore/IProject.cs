using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICore
{
    public interface IProject
    {

        #region Public Properties

        /// <summary>
        /// describes the position information on the Bill
        /// </summary>
        public string Id { get;  }

        /// <summary>
        /// the "created at" timestamp
        /// </summary>
        public DateTime CreatedAt { get;  }

        /// <summary>
        /// the "updated at" timestamp
        /// </summary>
        public DateTime UpdatedAt { get;  }

        /// <summary>
        /// the id of the associated bill
        /// </summary>
        public IBill IBill { get;  }

        /// <summary>
        /// the startdate of the project
        /// </summary>
        public DateTime StartDate { get;  }

        /// <summary>
        /// the enddate of the project
        /// </summary>
        public DateTime EndDate { get;  }

        /// <summary>
        /// The associated Customer of the project
        /// </summary>
        public ICustomer ICustomer { get;  }

        /// <summary>
        /// the leader/responsible Person of the project
        /// </summary>
        //public IUser ILeader { get; }

        /// <summary>
        /// the leader/responsible Person of the project
        /// </summary>
        public IUser IUser { get; }
        public IEnumerable<IUser> IUsers { get; }

        /// <summary>
        /// the status of the project/bill
        /// </summary>
        public ProjectStatusType Status { get;  }



        //public int BillId { get;  }
        //public ICompany Company { get;  }
        //public int ProjectId { get;  }
        //public string BillNumber { get;  }
        //public DateTime BillDate { get;  }
        //public ICustomer Customer { get;  }
        //public IService Service { get;  }
        //public IMaterial Material { get;  }
        //public int TaxRate { get;  }
        //public double IntermediatePrice { get;  }
        //public double TotalCost { get;  }
        //public string Employee { get;  }

        #endregion

        #region Private Properties


        #endregion

        #region Public Methods
        
        //print the Bill
        public void PrintBill();

        //add an article to the project
        public void AddArticle();

        //Delete an article from the project
        public void DeleteArticle();

        #endregion

        #region Private Methods


        #endregion

        #region Constructor


        #endregion


    }
}
