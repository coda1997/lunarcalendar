using System;

namespace lunarcalendar
{
    class LunarCalendar
    {
        private String slogan;
        private String isFriday;
        private String countDown;
        private readonly DateTime targetTime = new(2022, 1, 19, 18, 0, 0, 0, DateTimeKind.Local);

        public string CountDown 
        {
            get { 
                DateTime now = DateTime.Now;
                var offset = targetTime - now;
                countDown = "距离回家还有：" + offset.ToString("T");
                return countDown;
            }

            private set => countDown = value;
        }

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
