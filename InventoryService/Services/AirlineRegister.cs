using AirlinesService.DbContexts;
using AirlinesService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlinesService.Services
{
    public class AirlineRegister : IAirlineRegister
    {
        AirlineDbContext _AirlineContext;
        public AirlineRegister(AirlineDbContext AirlineContext)
        {
            _AirlineContext = AirlineContext;
        }

        public List<TblAirlineDetails> FindAllAirlineDetails()
        {
            return _AirlineContext.TblAirlineDetails.ToList();
        }

        public void RegisterAirline(TblAirlineDetails tblAirlineDetail)
        {
            _AirlineContext.TblAirlineDetails.Add(tblAirlineDetail);
            _AirlineContext.SaveChanges();
        }
    }
}
