using MvcApplication1.Business;
using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace MvcApplication1.Controllers
{
    [Authorize]
    public class LocationController : Controller
    {
        public ActionResult Create()
        {
            return View(new LocationForCreateModel()
            {
                LstCategory = (new CategoryBAL()).GetAll(),
                LstCategoryGroup = (new CategoryGroupBAL()).GetAll(),
            });
        }
        [HttpPost]
        public ActionResult Create(LocationForCreateModel model)
        {
            if (ModelState.IsValid)
            {
                // Lấy ra thông tin của người tạo địa điểm
                model.CreatedBy = WebSecurity.CurrentUserName;
                // Tạo mới địa điểm
                (new LocationBAL()).Create(model);
                // Gửi thông báo thêm mới thành công đến người dùng
                return View("CreateSuccess", new LocationSuccessForCreateModel() { 
                    LocationName = model.LocationName
                });
            }   

            model.LstCategory = (new CategoryBAL()).GetAll();
            model.LstCategoryGroup = (new CategoryGroupBAL()).GetAll();

            return View(model);
        }

        [AllowAnonymous]
        public ActionResult GetByCity(string cityUrl)
        {
            return View();
        }
        
        [AllowAnonymous]
        public ActionResult Detail(string location, string link)
        {
            var locationModel = new LocationForDetailModel();
            locationModel.RepImgLink = @"https://media.foody.vn/res/g32/311541/prof/s576x330/foody-mobile-2-jpg-167-636174156711051802.jpg";
            locationModel.LocationName = @"Trà Sữa TocoToco - Nguyễn Khang";
            locationModel.CityName = @"Hà Nội";
            locationModel.DistrictName = @"Quận Cầu Giấy";
            locationModel.WardName = @"28B Nguyễn Khang";
            locationModel.HrefLink = @"/ha-noi/tra-sua-tocotoco-nguyen-khang";
            locationModel.CityLink = @"/ha-noi/dia-diem";
            locationModel.DistrictLink = @"/ha-noi/khu-vuc-quan-cau-giay";
            locationModel.WardLink = @"/ha-noi/khu-vuc-bo-song";
            locationModel.ViewCount = 422;
            locationModel.CategoryName = "Café/Dessert";
            locationModel.CategoryLink = "/ha-noi/food/cafe";
            locationModel.CulinaryName = "Đài Loan";
            locationModel.CulinaryLink = "/ha-noi/cafe-phong-cach-dai-loan";
            locationModel.OrientedCustomer = "Sinh viên, Gia đình, Giới...";

            locationModel.AreaScore = 7.6;
            locationModel.AddressScore = 7.3;
            locationModel.ServiceScore = 7.0;
            locationModel.CostScore = 6.3;
            return View(locationModel);
        }
    }
}
