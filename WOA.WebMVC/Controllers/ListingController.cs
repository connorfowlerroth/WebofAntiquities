using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WOA.Contracts;
using WOA.Models;
using WOA.Services;

namespace WOA.WebMVC.Controllers
{
    
    public class ListingController : Controller
    {

        private readonly IListingService _listingService;

        public ListingController(IListingService listingService)
        {
            _listingService = listingService;
        }

        public IActionResult Index()
        {
            if (!SetUserId()) return Unauthorized();
            //var userId = Guid.Parse(User.Identity.GetUserId());
            var listing = new ListingListItem[0];
            return View(listing);
        }

        public IActionResult IndexGetId(int id)
        {
            var model = _listingService.GetListingsByUserId(id);
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

        private string GetUserId()
        {
            string userIdClaim = User.Claims.First(i => i.Type == ClaimTypes.NameIdentifier).Value;
            if (userIdClaim is null) return null;
            return userIdClaim;
        }

        private bool SetUserId()
        {
            string userId = GetUserId();
            if (userId == null) return false;

            _listingService.SetUserId(Guid.Parse(userId));
            return true;
        }
    }
}

