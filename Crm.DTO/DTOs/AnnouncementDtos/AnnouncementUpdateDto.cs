using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.DTO.DTOs.AnnouncementDtos
{
    public class AnnouncementUpdateDto
    {
        public int AnnouncementID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Publisher { get; set; }
        public DateTime Date { get; set; }
    }
}
