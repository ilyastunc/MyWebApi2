using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebApi2.Entitites;

namespace MyWebApi2.Repository.Abstract
{
    public interface IStationRepository
    {
        IQueryable<Station> GetStationListByFilter(Station entity);
    }
}