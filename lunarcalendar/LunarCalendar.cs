using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lunarcalendar
{
    class LunarCalendar
    {
        private String slogan;
        private String isFriday;

        public string IsFriday
        {
            get {
                if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
                {
                    isFriday = "今天是周五吗？是";
                }
                else 
                {
                    isFriday = "今天是周五吗？不是";
                }
                return isFriday;
            }

            private set => isFriday = value;
        }
        public string Slogan { get => slogan; set => slogan = value; }
    }
}
