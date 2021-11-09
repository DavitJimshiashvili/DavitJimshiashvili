using System;
using System.Collections.Generic;
using System.Text;

namespace Day_09_3
{
    class Time
    {
        public int _Hours;
        public int _Minutes;
        public int _Seconds;

        public int Hours
        {
            get
            {
                return _Hours;
            }
            set 
            {
                if (_Hours >= 0 && _Hours < 24)
                    _Hours = value;
            }
        }

        public int Minutes
        {
            get
            {
                return _Minutes;
            }
            set
            {
                if (_Minutes >= 0 && _Minutes < 60)
                    _Minutes = value;
            }
        }

        public int Seconds
        {
            get
            {
                return _Seconds;
            }
            set
            {
                if (_Seconds >= 0 && _Seconds < 60)
                    _Seconds = value;
            }
        }

        public void AddSecond()
        {
            if (_Seconds == 59)
            {
                _Seconds = 0;
                AddMinute();
            }

            else
                _Seconds++;

        }
        public void SubSecond()
        {
            if (_Seconds == 0)
            {
                SubMinute();
                _Seconds = 59;
            }

            else
                _Seconds--;
        }

        public void AddMinute()
        {
            if (_Minutes == 59)
            {
                AddHour();
                _Minutes = 0;
            }

            else
                _Minutes++;

        }
        public void SubMinute()
        {
            if (_Minutes == 0)
            {
                SubHour();
                _Minutes = 59;
            }

            else
                _Minutes--;
        }


        public void AddHour()
        {
            if (_Hours == 23)
                _Hours = 0;
            else
                _Hours++;

        }
        public void SubHour()
        {
            if (_Hours == 0)
                _Hours = 23;
            else
                _Hours--; 
        }



   

        StringBuilder sb = new StringBuilder();
        public void GetCurrentTime()
        {
            if (_Hours < 10)
                sb.Append("0");
            sb.Append(_Hours);
            sb.Append(":");
            if (_Minutes < 10)
                sb.Append("0");
            sb.Append(_Minutes);
            sb.Append(":");
            if (_Seconds < 10)
                sb.Append("0");
            sb.Append(_Seconds);


            Console.WriteLine(sb.ToString());
            sb.Clear();
        }
    }
}
