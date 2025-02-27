﻿using Login.Data;
using Login.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Login.Controllers
{
    public class AccountController : Controller
    {
        private LoginDbContext db;
        public AccountController(LoginDbContext Db)
        {
            db = Db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            ViewBag.role = new SelectList(db.Roles, "RoleId", "RoleName");
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login");

            }
            ViewBag.role = new SelectList(db.Roles, "RoleId", "RoleName");

            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            var data = db.Users.Where(x => x.Name == user.Name && x.Password == user.Password);

            if (data.Any())
            {
                return RedirectToAction("AllUsers");
            }
            else
            {
                return View();
            }
        }
        public IActionResult AllUsers()
        {
            return View(db.Users);
        }
    }
}

