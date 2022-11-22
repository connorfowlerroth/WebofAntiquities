using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WOA.Models;
using WOA.Services;

namespace WOA.WebMVC.Controllers
{
    [Authorize]
    public class ListingController : Controller
    {
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.Get+UserId());
            var Service = new ListingService(userId);
            var model = Service.GetListingsByUserId();

            return View(model);
        }

        //GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ListingCreate model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}

