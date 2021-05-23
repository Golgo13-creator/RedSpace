using RedSpace.Data;
using RedSpace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedSpace.WebMVC.Controllers
{
    
    public class ShipOriginController : Controller
    {
        
        // GET: ShipOrigin
        public ActionResult Index()
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            List<ShipOrigin> so = new List<ShipOrigin>();
            var Lists = (from ls in _context.LaunchSites
                         join s in _context.SpaceShips on ls.Id equals s.LaunchSiteId
                         select new { ls.Name, ls.Location, s.ShipName, s.CrewCapacity }).ToList();
            foreach(var item in Lists)
            {
                ShipOrigin shipOrigin = new ShipOrigin();
                shipOrigin.Name = item.Name;
                shipOrigin.Location = item.Location;
                shipOrigin.ShipName = item.ShipName;
                shipOrigin.CrewCapacity = item.CrewCapacity;
                so.Add(shipOrigin);
            }
            return View(so);
        }
    }
}