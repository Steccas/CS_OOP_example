using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessione31032016
{
    public interface IDate
    {
        int day { get; set; }
        int month { get; set; }
        int year { get; set; }
    }

    public interface IDay
    {
        int h { get; set; }
        int m { get; set; }
    }

    public class date : IDate {
        private int _day;
        private int _month;
        private int _year;

        public date() {
            _day = _month = _year = 0;
        }

        public int day {
            get { return _day; }
            set {
                if ((value > 0) && (value < 30)) _day = value;
                else System.Console.WriteLine("Invalid value!");
            }
        }

        public int month
        {
            get { return _month; }
            set
            {
                if (value > 0 && value < 13) _month = value;
                else System.Console.WriteLine("Invalid value!");
            }
        }

        public int year
        {
            get { return _year; }
            set { _year = value; }
        }
    }

    public class day : date, IDay {
        private int _h, _m;
        public day() {
            _h = _m = 0;
        }
        public int h
        {
            get { return _h; }
            set
            {
                if (value >= 0 && value <= 24) _h = value;
                else System.Console.WriteLine("Invalid value!");
            }
        }

        public int m
        {
            get { return _m; }
            set
            {
                if (value >= 0 && value <= 59) _m = value;
                else System.Console.WriteLine("Invalid value!");
            }
        }
    }
}
