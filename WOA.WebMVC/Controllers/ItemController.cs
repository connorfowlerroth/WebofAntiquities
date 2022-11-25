using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WOA.Contracts;
using WOA.Models;
using WOA.Services;

namespace WOA.WebMVC.Controllers
{
    public class ItemController : Controller
    {

        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        public IActionResult Index()
        {
            var listing = new ItemListItem[0];
            return View(listing);
        }

        public IActionResult Create()
        {
            return View();

        }

    }
}

