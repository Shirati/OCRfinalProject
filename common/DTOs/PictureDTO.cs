using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.DTOs
{
    public class PictureDTO
    {
        public int PictureId { get; set; }

        public int? ActionId { get; set; }

        public string? SourceFileUrl { get; set; }

        public string? ResultFileUrl { get; set; }
       
    }

}
