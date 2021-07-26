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
    public class Project : IProject
    {

        #region Public Properties

        /// <summary>
        /// The Unique ID of the Project
        /// </summary>
        [MaxLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// The Date when the project was created
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The Date when the project was updated
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The Bill of the whole Project
        /// </summary>
        [NotMapped]
        IBill IProject.IBill => (IBill)Bill;
        public Bill Bill { get; set; }

        /// <summary>
        /// The startdate of the project
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The enddate of the project
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// the customer of the project
        /// </summary>
        [NotMapped]
        ICustomer IProject.ICustomer => this.Customer;
        public Customer Customer { get; set; }

        /// <summary>
        /// the leader/responsible Person of the project
        /// </summary>
        //[NotMapped]
        //public IUser ILeader => Leader;
        //public User Leader { get; set; }

        /// <summary>
        /// the users of the project
        /// </summary>
        [NotMapped]
        public IEnumerable<IUser> IUsers => Users;
        public List<User> Users { get; set; } = new List<User>();

        [NotMapped]
        public IUser IUser => User;
        public User User { get; set; }

        /// <summary>
        /// the project status
        /// </summary>
        [NotMapped]
        public ProjectStatusType Status { get; set; } = ProjectStatusType.Pending;

        #endregion

        #region Private Properties


        #endregion

        #region Public Methods
        //print the Bill
        public void PrintBill() { }

        //add an article to the project
        public void AddArticle() { }

        //Delete an article from the project
        public void DeleteArticle() { }

        #endregion

        #region Private Methods


        #endregion

        #region Constructor

        public Project()
        {

        }


        #endregion


    }
}
