using SeafoodEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class RegisterInfoModel
    {
        //[Required]
        //public string UserName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string UserEmail { get; set; }
        public string CityCode { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string ConfirmPassword { get; set; }

        public List<City> LstCity { get; set; }

        public RegisterInfoModel()
        {
            LstCity = new List<City>();
        }
    }

}