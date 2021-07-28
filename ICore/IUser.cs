using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICore
{
    public interface IUser
    {
        #region Public Properties

        /// <summary>
        /// the unique id of the position
        /// </summary>
        public string Id { get;  }

        /// <summary>
        /// the username(to login) of the user
        /// </summary>
        public string Username { get;  }

        /// <summary>
        /// the email of the user
        /// </summary>
        public string Email { get;  }

        /// <summary>
        /// the password of the user
        /// </summary>
        public string Password { get;  }

        /// <summary>
        /// the company where the user works
        /// </summary>
        public ICompany ICompany { get; }
        #endregion

        #region Private Properties


        #endregion

        #region Public Methods

        //change Userpassword
        public void ChangePass(string oldPass, string newPass);

        //create a new User
        public void CreateUser();

        //find/get a specific User
        public void GetUser();

        //Update User information
        public void UpdateUser();

        //delete a User from the database
        public void DeleteUser();

        #endregion

        #region Private Methods


        #endregion

        #region Constructor


        #endregion




    }
}
