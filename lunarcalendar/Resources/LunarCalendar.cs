using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lunarcalendar.Resources
{
    class LunarCalendar
    {
        private String slogan;
        private String isFriday;
        private readonly DateTime dateTime = new DateTime();

        public string IsFriday { get => isFriday; set => isFriday = value; }
        public string Slogan { get => slogan; set => slogan = value; }
    }
}
