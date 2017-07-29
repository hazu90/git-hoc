using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeafoodAdmin.Models
{
    public class CurrentUserModel
    {
        private string _userName { get; set; }
        private bool _isAuthenticated { get; set; }
        public CurrentUserModel(string userName ,bool isAuthenticated)
        {
            this._userName = userName;
            this._isAuthenticated = IsAuthenticated;
        }
        public string UserName { get { return _userName; } }
        public bool IsAuthenticated { get { return _isAuthenticated; } }
    }
}