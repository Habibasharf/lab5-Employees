using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
     class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Second { get; set; }
        public Duration()
        {
            Hours = 0;
            Minutes = 0;
            Second = 0;
        }
        public Duration(int _h,int _m,int _s)
        {
            Hours = _h;
            Minutes = _m;
            Second = _s;
        }
        public Duration(int _s)
        {
            Second = _s;
            Hours = Second / (60 * 60);
            Minutes = (Second-Hours*3600)/ 60;
            Second =  (Second-Hours*3600)%60;
        }
        public void Print()
        {
             
            if(Hours != 0)
            {
                Console.WriteLine($"Hours = {Hours} , Minutes = {Minutes} , Second = {Second}");
            }
            else
            {
                Console.WriteLine($"Minutes = {Minutes} , Second = {Second}");
            }

        }
        public static Duration operator +(Duration _d1, Duration _d2)
        {
            // stdone+stdtwo
            Duration result = new Duration(){ Hours = _d1.Hours + _d2.Hours, Minutes = _d1.Minutes + _d2.Minutes, Second = _d1.Second + _d2.Second };
            if ((_d1.Hours + _d2.Hours) > 24)
            {
                int day = result.Hours / 24;
                result.Hours = (result.Hours - day * 24);

            }
            if (_d1.Minutes + _d2.Minutes > 60)
            {
                result.Hours += result.Minutes / 60;
                result.Minutes = result.Minutes - (result.Minutes / 60) * 60;
            }
            if (_d1.Second + _d2.Second > 60)
            {
                result.Minutes += result.Second / 60;
                result.Second = result.Second - (result.Second / 60) * 60;
            }
            return result;
        }
        public static Duration operator +(Duration _d1, int x)
        {
            Duration _d = new Duration(x);
            // stdone+stdtwo
            Duration result = new Duration(){ Hours = _d1.Hours + _d.Hours, Minutes = _d1.Minutes + _d.Minutes, Second = _d1.Second + _d.Second };
            if ((_d1.Hours + _d.Hours) > 24)
            {
                int day = result.Hours / 24;
                result.Hours = (result.Hours - day * 24);
                
            }
            if (_d1.Minutes + _d.Minutes > 60)
            {
                result.Hours += result.Minutes / 60;
                result.Minutes = result.Minutes - (result.Minutes / 60) * 60;
            }
            if (_d1.Second + _d.Second > 60)
            {
                result.Minutes += result.Second / 60;
                result.Second = result.Second - (result.Second / 60) * 60;
            }
            return result;
        }
        public static bool operator >(Duration _D1, Duration _D2)
        {
            return _D1.Hours > _D2.Hours && _D1.Minutes > _D2.Minutes && _D1.Second > _D2.Second;
        }
        public static bool operator <(Duration _D1, Duration _D2)
        {
            return !(_D1 > _D2);

        }

        public static bool operator <=(Duration _D1, Duration _D2)
        {
            return _D1.Hours <= _D2.Hours && _D1.Minutes <= _D2.Minutes && _D1.Second <= _D2.Second;
        }
        public static bool operator >=(Duration _D1, Duration _D2)
        {
            return !(_D1 >= _D2);

        }
    }
}
