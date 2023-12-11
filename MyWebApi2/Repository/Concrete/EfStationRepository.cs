using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebApi2.Repository.Abstract;
using MyWebApi2.Entitites;
using Microsoft.EntityFrameworkCore;

namespace MyWebApi2.Repository.Concrete
{
    public class EfStationRepository : IStationRepository
    {
        private AppDbContext _context;
        public EfStationRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Station> GetStationListByFilter(Station entity)
        {
            return _context.Stations.FromSql($"CL_Get_Station_List_By_Location {entity.Lat}, {entity.Lon}, '478c3bb4-22d6-ea11-80fa-1c98ec2a68c7', false, false, 2, '', 'OTO YIKAMA', false, 2, 50000, false, false, false; ");
        }
    }
}