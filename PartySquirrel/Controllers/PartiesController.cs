using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PartySquirrel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace PartySquirrel.Controllers
{
  public class PartiesController : Controller
  {
    private readonly PartySquirrelContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public PartiesController(PartySquirrelContext db, UserManager<ApplicationUser> userManager)
    {
      _db = db;
      _userManager = userManager;
    } 
    public IActionResult Index() //Party Index. see all the other users parties
    {
      // var result = _db.UserIds.User.Identity.Name //get all usernames.ToList();
      return View();
    }
  }
}