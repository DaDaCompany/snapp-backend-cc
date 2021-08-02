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
    public class User : IUser
    {

        #region Public Properties

        /// <summary>
        /// the unique id of the position
        /// </summary>
        [Key]
        [MaxLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// the username(to login) of the user
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// the email of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// the password of the user
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// the company where the user works
        /// </summary>
        [NotMapped]
        public ICompany ICompany => this.Company;
        public Company Company { get; set; }

        /// <summary>
        /// the id of the company where the user works
        /// </summary>
        public string CompanyId { get; set; }

        #endregion

        #region Private Properties


        #endregion

        #region Public Methods

        //change Userpassword
        public void ChangePass(string oldPass, string newPass) { }

        //create a new User
        public void CreateUser() { }

        //find/get a specific User
        public void GetUser() { }

        //Update User information
        public void UpdateUser() { }

        //delete a User from the database
        public void DeleteUser() { }

        #endregion

        #region Private Methods


        #endregion

        #region Constructor
        public User()
        {

        }


        #endregion



    }
}
