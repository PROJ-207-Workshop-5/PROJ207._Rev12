﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Workshop5.Rev2.BLL;
using Workshop5.Rev2.Data.Domain;

namespace Workshop5.Rev2.App.Controllers
{
    public class AgentController : Controller
    {
        public IActionResult Login(string returnUrl = null)
        {
            if (returnUrl != null)
                TempData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(Agents agent)
        {
            var user = AgentManager.Authenticate(agent.AgtEmail, agent.AgtPassword);
            // no user is found
            if (user == null) return View();
            // user is found
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Email, user.AgtEmail),
                new Claim("Password", user.AgtPassword)
            };
            // create the instance of ClaimsIdentity

            var claimsIdentity = new ClaimsIdentity(claims, "Cookies");
            await HttpContext.SignInAsync("Cookies", new ClaimsPrincipal(claimsIdentity));

            //handle the return url
            if (TempData["ReturnUrl"] == null)
            {

                return RedirectToAction("Index", "Agent");
            }

            else
                return Redirect(TempData["ReturnUrl"].ToString());

        }

       
        public IActionResult Index()
        {
            var packages = PackageManager.GetAll();
            return View(packages);
           
        }

        public ActionResult Details()
        {
            var packages = PackageManager.GetAll();
            return View(packages);
        }
        public ActionResult Data(int id)

        {
            var packages = PackageManager.GetAll();
            var package = packages.SingleOrDefault(m => m.PackageId == id);
            return PartialView("_PackageDetails", package);

        }

        public ActionResult CustomerDetails()
        {
            var customers = CustomerManager.GetAll();
            return View(customers);
        }
        public ActionResult CustomerData(int id)

        {
            var customers = CustomerManager.GetAll();
            var customer = customers.SingleOrDefault(m => m.CustomerId == id);
            return PartialView("_CustomerDetails", customer);

        }
    }
}
