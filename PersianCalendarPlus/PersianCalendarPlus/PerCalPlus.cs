using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersianCalendarPlus
{
    /*
    * PersianCalendarPlus v1
    * Copyright (c) 2015 Hamid Mosalla => http://hamidmosalla.com
    * Licensed under The MIT License (MIT)
    * https://opensource.org/licenses/MIT
    * Just use it and enjoy, twitter handle: @xellarix
    */
    public static class PerCalPlus
    {
        public static string Now()
        {
            PersianCalendar PerCal = new PersianCalendar();

            return string.Format("{0:0000}/{1:00}/{2:00} {3}"
                , PerCal.GetYear(DateTime.Now)
                , PerCal.GetMonth(DateTime.Now)
                , PerCal.GetDayOfMonth(DateTime.Now)
                , DateTime.Now.ToString("hh:mm:ss tt", new CultureInfo("fa-IR")));
        }
        public static string ToShortDateString()
        {
            PersianCalendar PerCal = new PersianCalendar();

            return string.Format("{0:0000}/{1:00}/{2:00}"
                , PerCal.GetYear(DateTime.Now)
                , PerCal.GetMonth(DateTime.Now)
                , PerCal.GetDayOfMonth(DateTime.Now));

        }
        public static string ToLongDateString()
        {
            PersianCalendar PerCal = new PersianCalendar();

            return GetDayOfWeekName() + " - " + PerCal.GetDayOfMonth(DateTime.Now) + " " + GetMonthName() + " - " +
                   PerCal.GetYear(DateTime.Now);
        }



        public static int GetPersianYear()
        {
            PersianCalendar PerCal = new PersianCalendar();
            return PerCal.GetYear(DateTime.Now);
        }
        public static int GetPersianYear(int gregorianYear)
        {
            try
            {
                DateTime dt = new DateTime(gregorianYear, 1, 1);
                PersianCalendar PerCal = new PersianCalendar();
                return PerCal.GetYear(dt);
            }
            catch
            {
                throw new ArgumentException("The provided year was not in a valid format.");
            }

        }
        public static int GetPersianMonth()
        {
            PersianCalendar PerCal = new PersianCalendar();
            return PerCal.GetMonth(DateTime.Now);
        }
        public static int GetPersianMonth(int gregorianMonth, int gregorianDay)
        {
            try
            {
                DateTime dt = new DateTime(DateTime.Now.Year, gregorianMonth, gregorianDay);
                PersianCalendar PerCal = new PersianCalendar();
                return PerCal.GetMonth(dt);
            }
            catch
            {
                throw new ArgumentException("The provided arguments were not in valid format.");
            }
        }
        public static int GetPersianDay()
        {
            PersianCalendar PerCal = new PersianCalendar();
            return PerCal.GetDayOfMonth(DateTime.Now);
        }
        public static int GetPersianDay(int gregorianYear, int gregorianMonth, int gregorianDay)
        {
            try
            {
                DateTime dt = new DateTime(gregorianYear, gregorianMonth, gregorianDay);
                PersianCalendar PerCal = new PersianCalendar();
                return PerCal.GetDayOfMonth(dt);
            }
            catch
            {
                throw new ArgumentException("The provided arguments were not in valid format.");
            }
        }
        public static int GetDaysInPersianMonth(int year, int month)
        {
            try
            {
                PersianCalendar PerCal = new PersianCalendar();
                return PerCal.GetDaysInMonth(year, month);
            }
            catch
            {
                throw new ArgumentException("The provided arguments were not in valid format.");
            }
        }
        public static int GetDaysInPersianYear(int year)
        {
            try
            {
                PersianCalendar PerCal = new PersianCalendar();
                return PerCal.GetDaysInYear(year);
            }
            catch
            {
                throw new ArgumentException("The provided arguments were not in valid format.");
            }
        }



        public static string GetDayOfWeekName()
        {
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                    return "شنبه";
                case DayOfWeek.Sunday:
                    return "يکشنبه";
                case DayOfWeek.Monday:
                    return "دوشنبه";
                case DayOfWeek.Tuesday:
                    return "سه‏ شنبه";
                case DayOfWeek.Wednesday:
                    return "چهارشنبه";
                case DayOfWeek.Thursday:
                    return "پنجشنبه";
                case DayOfWeek.Friday:
                    return "جمعه";
                default:
                    return "";
            }
        }
        public static string GetDayOfWeekName(DateTime date)
        {
            try
            {
                switch (date.DayOfWeek)
                {
                    case DayOfWeek.Saturday:
                        return "شنبه";
                    case DayOfWeek.Sunday:
                        return "يکشنبه";
                    case DayOfWeek.Monday:
                        return "دوشنبه";
                    case DayOfWeek.Tuesday:
                        return "سه‏ شنبه";
                    case DayOfWeek.Wednesday:
                        return "چهارشنبه";
                    case DayOfWeek.Thursday:
                        return "پنجشنبه";
                    case DayOfWeek.Friday:
                        return "جمعه";
                    default:
                        return "";
                }
            }
            catch
            {
                throw new ArgumentException("Provided argument was not in valid format.");
            }
        }
        public static string GetMonthName()
        {
            PersianCalendar PerCal = new PersianCalendar();

            switch (PerCal.GetMonth(DateTime.Now))
            {
                case 1:
                    return "فروردین";
                case 2:
                    return "اردیبهشت";
                case 3:
                    return "خرداد";
                case 4:
                    return "تیر‏";
                case 5:
                    return "مرداد";
                case 6:
                    return "شهریور";
                case 7:
                    return "مهر";
                case 8:
                    return "آبان";
                case 9:
                    return "آذر";
                case 10:
                    return "دي";
                case 11:
                    return "بهمن";
                case 12:
                    return "اسفند";
                default:
                    return "";
            }

        }
        public static string GetMonthName(DateTime date)
        {
            PersianCalendar PerCal = new PersianCalendar();
            try
            {
                switch (PerCal.GetMonth(date))
                {
                    case 1:
                        return "فروردین";
                    case 2:
                        return "اردیبهشت";
                    case 3:
                        return "خرداد";
                    case 4:
                        return "تیر‏";
                    case 5:
                        return "مرداد";
                    case 6:
                        return "شهریور";
                    case 7:
                        return "مهر";
                    case 8:
                        return "آبان";
                    case 9:
                        return "آذر";
                    case 10:
                        return "دي";
                    case 11:
                        return "بهمن";
                    case 12:
                        return "اسفند";
                    default:
                        return "";
                }
            }
            catch
            {
                throw new ArgumentException("Provided argument was not in valid format.");
            }
        }

        public static int PersianMonthStringToNumber(string monthName)
        {
            try
            {
                switch (monthName)
                {
                    case "فروردین":
                        return 1;
                    case "اردیبهشت":
                        return 2;
                    case "خرداد":
                        return 3;
                    case "تیر‏":
                        return 4;
                    case "مرداد":
                        return 5;
                    case "شهریور":
                        return 6;
                    case "مهر":
                        return 7;
                    case "آبان":
                        return 8;
                    case "آذر":
                        return 9;
                    case "دي":
                        return 10;
                    case "بهمن":
                        return 11;
                    case "اسفند":
                        return 12;
                    default:
                        return -1;
                }
            }
            catch
            {
                throw new ArgumentException("The monthName string was not in valid format, make sure it does not contain any leading or trailing white space.");
            }
        }


        public static string GregorianDateToPersian(int year, int month, int day)
        {
            try
            {
                DateTime dt = new DateTime(year, month, day);
                PersianCalendar PerCal = new PersianCalendar();


                return string.Format("{0:0000}/{1:00}/{2:00}"
                , PerCal.GetYear(dt)
                , PerCal.GetMonth(dt)
                , PerCal.GetDayOfMonth(dt));
            }
            catch
            {
                throw new FormatException("Provided arguments where not in valid format.");
            }
        }
        public static string GregorianDateToPersian(string date)
        {
            try
            {
                DateTime dt = DateTime.ParseExact(date, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

                PersianCalendar PerCal = new PersianCalendar();


                return string.Format("{0:0000}/{1:00}/{2:00}"
                , PerCal.GetYear(dt)
                , PerCal.GetMonth(dt)
                , PerCal.GetDayOfMonth(dt));
            }
            catch
            {
                throw new FormatException("The input string must be in year/month/day format with digits of 0/0/0000 0:00:00 PM/AM like => 5/27/2015 3:14:25 PM");
            }
        }
        public static string GregorianDateToPersian(DateTime date)
        {
            var PerCal = new PersianCalendar();

            try
            {
                return string.Format("{0:0000}/{1:00}/{2:00}"
                , PerCal.GetYear(date)
                , PerCal.GetMonth(date)
                , PerCal.GetDayOfMonth(date));
            }
            catch
            {
                throw new ArgumentException("The provided arguments were not in valid format.");
            }
        }
        public static string GregorianDateToPersianLong(DateTime date)
        {
            var PerCal = new PersianCalendar();

            try
            {
                return GetDayOfWeekName(date) + " - " + PerCal.GetDayOfMonth(date) + " " + GetMonthName(date) + " - " +
                   PerCal.GetYear(date);
            }
            catch
            {
                throw new ArgumentException("The provided arguments were not in valid format.");
            }
        }


        public enum DateStringType
        {
            Now,
            ToShortDateString,
            ToLongDateString
        };
        public static DateTime PersianDateToGregorian(int year, int month, int day)
        {
            PersianCalendar PerCal = new PersianCalendar();

            try
            {
                //You can do this too : DateTime dt = new DateTime(year, month, day, PerCal or new PersianCalendar());
                DateTime date = PerCal.ToDateTime(year, month, day, 0, 0, 0, 0, PersianCalendar.PersianEra);
                return date;
            }
            catch
            {
                throw new FormatException("The arguments must be in year/month/day format with digits of 0000/00/00.");
            }
        }
        public static DateTime PersianDateToGregorian(int year, int month, int day, int hour, int minute, int second)
        {
            PersianCalendar PerCal = new PersianCalendar();

            try
            {
                DateTime date = PerCal.ToDateTime(year, month, day, hour, minute, second, 0, PersianCalendar.PersianEra);
                return date;
            }
            catch
            {
                throw new FormatException("The arguments must be in year/month/day hour, minute, second format.");
            }
        }
        public static DateTime PersianDateToGregorian(string persianDateString, DateStringType dateStringType)
        {
            PersianCalendar PerCal = new PersianCalendar();

            try
            {
                if (dateStringType == DateStringType.ToShortDateString)
                {
                    var dateArray = persianDateString.Split('/');

                    DateTime date = PerCal.ToDateTime(int.Parse(dateArray[0]), int.Parse(dateArray[1]), int.Parse(dateArray[2]), 0, 0, 0, 0, PersianCalendar.PersianEra);
                    return date;
                }

                if (dateStringType == DateStringType.Now)
                {
                    var dateArray = persianDateString.Split('/');
                    var daySection = dateArray[2].Split(' ');
                    DateTime date = PerCal.ToDateTime(int.Parse(dateArray[0]), int.Parse(dateArray[1]), int.Parse(daySection[0]), 0, 0, 0, 0, PersianCalendar.PersianEra);
                    return date;
                }

                if (dateStringType == DateStringType.ToLongDateString)
                {
                    var dateArray = persianDateString.Split('-');
                    var monthAndDay = dateArray[1].Trim().Split(' ');

                    DateTime date = PerCal.ToDateTime(int.Parse(dateArray[2]), PersianMonthStringToNumber(monthAndDay[1]), int.Parse(monthAndDay[0]), 0, 0, 0, 0, PersianCalendar.PersianEra);
                    return date;
                }
            }
            catch
            {
                throw new ArgumentException("The date string argument was not in valid format, make sure you chose a correct DateStringType, or your date string conform to PerCalPlus.Now or PerCalPlus.ToLongDateString or PerCalPlus.ToShortDateString date string format.");
            }
            return DateTime.Now;
        }



        public static int ShortYearToLongYear(int year)
        {
            try
            {
                PersianCalendar PerCal = new PersianCalendar();
                return PerCal.ToFourDigitYear(year);
            }
            catch
            {
                throw new FormatException("The input year was not in valid format");
            }

        }

        public static int ShortYearToLongYear(string year)
        {
            try
            {
                PersianCalendar PerCal = new PersianCalendar();

                return PerCal.ToFourDigitYear(int.Parse(year));
            }
            catch
            {
                throw new FormatException("The year string was not in valid format");
            }
        }
    }

}
