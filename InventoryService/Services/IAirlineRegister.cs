using AirlinesService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlinesService.Services
{
   public interface IAirlineRegister
    {
        List<TblAirlineDetails> FindAllAirlineDetails();
        void RegisterAirline(TblAirlineDetails tblAirlineDetail);
    }
}
