using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlinesService.Models
{
    public class TblAirlineDetails
    {
        public int Id { get; set; }
        public string AirlineName { get; set; }
        public byte[] UploadLogo { get; set; }
        public int? ContactNumber { get; set; }
        public string ContactAddress { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
