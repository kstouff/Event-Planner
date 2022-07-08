using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Belt.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Belt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private BeltContext db;

        public HomeController(BeltContext context, ILogger<HomeController> logger)
        {
            _logger = logger;
            db = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            // Check initial ModelState
            if(ModelState.IsValid)
            {
                // If a User exists with provided email
                if(db.Users.Any(u => u.Email == newUser.Email))
                {
                    // Manually add a ModelState error to the Email field, with provided
                    // error message
                    ModelState.AddModelError("Email", "Email already in use!");
                    
                }
            } 
                if(ModelState.IsValid == false)
                {
                    return View("Index");
                }
            PasswordHasher<User> Hasher = new PasswordHasher<User>();
            newUser.Password = Hasher.HashPassword(newUser, newUser.Password);

            db.Users.Add(newUser);
            db.SaveChanges();

            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            HttpContext.Session.SetString("Name", newUser.Name);

            
            return RedirectToAction("AllMeetups");
        } 



        [HttpPost("login")]
        public IActionResult Login(LoginUser userSubmission)
        {
            if(ModelState.IsValid)
            {
                var userInDb = db.Users.FirstOrDefault(u => u.Email == userSubmission.LoginEmail);
                if(userInDb == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email or Password");
                }
                if(ModelState.IsValid == false)
                {
                    return View("Index");
                }

                var hasher = new PasswordHasher<LoginUser>();

                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.LoginPassword);

                if(result == 0)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email or Password");
                    return View("Index");
                }
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                HttpContext.Session.SetString("Name", userInDb.Name);
                return Redirect("AllMeetups");
            }
            return View("Index");
        }



        [HttpGet("allMeetups")]
        public IActionResult AllMeetups()
        {
            if(HttpContext.Session.GetInt32("UserId") != null)
            {     
                ViewBag.allMeetups = db.Meetups.
                Include(m => m.Attendees).
                Include(m => m.Creator).
                OrderBy(m => m.Date).
                ToList();

                ViewBag.userId = HttpContext.Session.GetInt32("UserId");
                ViewBag.userName = HttpContext.Session.GetString("Name");
                return View();
            }

            ModelState.AddModelError("Email", "Must be logged in to Acces this page");
            return RedirectToAction("Index");
        }

        [HttpGet("/meetups/{MeetupId}")]
        public IActionResult OneMeetup(int MeetupId)
        {
            if(HttpContext.Session.GetInt32("UserId") != null)
            {     
                Meetup meetup = db.Meetups.Include(m => m.Creator).Include(m => m.Attendees).ThenInclude(a => a.User).FirstOrDefault(m => m.MeetupId == MeetupId);
            
                ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            
                return View(meetup);
            }

            ModelState.AddModelError("Email", "Must be logged in to Acces this page");
            return RedirectToAction("Index");
            
            
        }

        [HttpGet("addMeetup")]
        public IActionResult AddMeetup()
        {
            if(HttpContext.Session.GetInt32("UserId") != null)
            {     
                ViewBag.userId = HttpContext.Session.GetInt32("UserId");
                ViewBag.userName = HttpContext.Session.GetString("Name");
                return View();
            }

            ModelState.AddModelError("Email", "Must be logged in to Acces this page");
            return RedirectToAction("Index");
        }

        [HttpPost("/submitMeetup")]
        public IActionResult SubmitMeetup(Meetup newMeetup)
        {
            ViewBag.userId = HttpContext.Session.GetInt32("UserId");
            ViewBag.userName = HttpContext.Session.GetString("Name");
            if(ModelState.IsValid == false)
            {
                Console.WriteLine("______INVALID_______");
                return View("AddMeetup");
            }
            db.Meetups.Add(newMeetup);
            db.SaveChanges();

            return RedirectToAction("AllMeetups");
            
        }







        [HttpPost("/submitRSVP")]
        public IActionResult SubmitRSVP(RSVP newRSVP)
        {
                db.RSVPs.Add(newRSVP);
                db.SaveChanges();
                return RedirectToAction("AllMeetups");
            
        }
        [HttpPost("/submitUnRSVP")]
        public IActionResult SubmitUnRSVP(RSVP newRSVP)
        {
                RSVP tempRSVP = db.RSVPs.FirstOrDefault(rsvp => rsvp.UserId == newRSVP.UserId && rsvp.MeetupId == newRSVP.MeetupId);
                db.RSVPs.Remove(tempRSVP);
                db.SaveChanges();
                return RedirectToAction("AllMeetups");
            
        }
        [HttpPost("/deleteMeetup")]
        public IActionResult DeleteMeetup(RSVP newRSVP)
        {
                Meetup meetup = db.Meetups.FirstOrDefault(rsvp => rsvp.MeetupId == newRSVP.MeetupId);
                db.Meetups.Remove(meetup);
                db.SaveChanges();
                return RedirectToAction("AllMeetups");
            
        }

        [HttpGet("/logOut")]
        public IActionResult LogOut()
        {
                HttpContext.Session.Clear();
                return View("Index");
            
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
