using RedSpace.Data;
using RedSpace.Models.SpaceShipModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSpace.Services
{
    public class SpaceShipService
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        //create 
        public bool CreateSpaceShip(SpaceShipCreate model)
        {
            SpaceShip entity = new SpaceShip
            {
                ShipName = model.ShipName,
                CrewCapacity = model.CrewCapacity,
                CreatedUtc = DateTimeOffset.Now,
                LaunchSiteId = model.LaunchSiteId
            };
            _context.SpaceShips.Add(entity);
            return _context.SaveChanges() == 1;
        }
        //get all
        public List<SpaceShipDetail> GetAllSpaceShips()
        {
            var spaceshipEntities = _context.SpaceShips.ToList();
            var spaceshipList = spaceshipEntities.Select(s => new SpaceShipDetail
            {
                Id = s.Id,
                ShipName = s.ShipName,
                CrewCapacity = s.CrewCapacity,
                CreatedUtc = s.CreatedUtc,
                ModifiedUtc = s.ModifiedUtc,
                LaunchSiteId = s.LaunchSiteId
            }).ToList();
            return spaceshipList;
        }
        //get (details by id)
        public SpaceShipDetail GetSpaceShipById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .SpaceShips
                        .Single(s => s.Id == id);
                return
                     new SpaceShipDetail
                     {
                         Id = entity.Id,
                         ShipName = entity.ShipName,
                         CrewCapacity = entity.CrewCapacity,
                         CreatedUtc = entity.CreatedUtc,
                         ModifiedUtc = entity.ModifiedUtc,
                         LaunchSiteId = entity.LaunchSiteId
                     };
            }
        }
        //update
        public bool UpdateSpaceShip(SpaceShipEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var oldData =
                    ctx
                    .SpaceShips
                    .Single(s => s.Id == model.Id);
                oldData.Id = model.Id;
                oldData.ShipName = model.ShipName;
                oldData.CrewCapacity = model.CrewCapacity;
                oldData.ModifiedUtc = DateTimeOffset.Now;
                oldData.LaunchSiteId = model.LaunchSiteId;
                return ctx.SaveChanges() == 1;
            }
        }
        //delete
        public bool DeleteSpaceShip(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var shipToDelete =
                    ctx
                    .SpaceShips
                    .Single(s => s.Id == id);
                if (shipToDelete != null)
                {
                    ctx.SpaceShips.Remove(shipToDelete);
                    return ctx.SaveChanges() == 1;
                }
                return false;
            }
        }
    }
}

