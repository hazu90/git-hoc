using HelperLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Models
{
    public class UserInformationForEditModel
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserEmail { get; set; }
        public string CityCode { get; set; }
        public int Status { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string Description { get; set; }
        public bool IsPrivate { get; set; }
        public string Yahoo { get; set; }
        public string FacebookUrl { get; set; }
        public string Skype { get; set; }
        public string Phone { get; set; }
        public int StatusPublishedType { get; set; }
        public int DayOfBirthPublishedType { get; set; }
        public int GenderPublishedType { get; set; }
        public int DescriptionPublishedType { get; set; }
        public int YahooSettingTypeNumber { get; set; }
        public int FacebookUrlSettingTypeNumber { get; set; }
        public int SkypeSettingTypeNumber { get; set; }
        public IEnumerable<SelectListItem> LstRelationStatus 
        { 
            get {
                return AppEnumDescriptionHelper.ListRelationStatus().Select(o => new SelectListItem()
                {
                    Value = o.Key.ToString(),
                    Text = o.Value
                }).AsEnumerable();
            } 
        }
        public IEnumerable<SelectListItem> LstPrivateStatus 
        { 
            get {
                return AppEnumDescriptionHelper.ListPrivateStatus().Select(o => new SelectListItem()
                {
                    Value = o.Key.ToString(),
                    Text = o.Value
                }).AsEnumerable();
            } 
        }
    }
}