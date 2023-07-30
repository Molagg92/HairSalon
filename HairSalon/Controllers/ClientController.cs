using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;


namespace HairSalon.Controllers
{
  public class ClientController : Controller
  {
    public readonly HairSalonContext _db;
    public ClientController(HairSalonContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Client>model = _db.Clients
                              .Include(client => client.Stylist)
                              .ToList();
    return View(model); 
    }
  }
}
