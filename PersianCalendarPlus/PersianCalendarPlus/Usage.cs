using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersianCalendarPlus
{
    class Usage
    {
        static void Main(string[] args)
        {

            Debug.WriteLine("");
            Debug.WriteLine("");
            Debug.WriteLine("");
            Debug.WriteLine("*********************************************************************************************************");


            Debug.WriteLine(PerCalPlus.Now());
            Debug.WriteLine(PerCalPlus.ToShortDateString());
            Debug.WriteLine(PerCalPlus.ToLongDateString());

            Debug.WriteLine(PerCalPlus.GetPersianYear());
            Debug.WriteLine(PerCalPlus.GetPersianYear(1988));
            Debug.WriteLine(PerCalPlus.GetPersianMonth());
            Debug.WriteLine(PerCalPlus.GetPersianMonth(2, 21));
            Debug.WriteLine(PerCalPlus.GetPersianDay());
            Debug.WriteLine(PerCalPlus.GetPersianDay(1988, 2, 21));
            Debug.WriteLine(PerCalPlus.GetDaysInPersianMonth(66, 12));
            Debug.WriteLine(PerCalPlus.GetDaysInPersianYear(66));


            Debug.WriteLine(PerCalPlus.GetDayOfWeekName());
            Debug.WriteLine(PerCalPlus.GetDayOfWeekName(DateTime.Now.AddDays(2)));
            Debug.WriteLine(PerCalPlus.GetMonthName());
            Debug.WriteLine(PerCalPlus.GetMonthName(DateTime.Now.AddDays(2)));


            Debug.WriteLine(PerCalPlus.GregorianDateToPersian(1999, 8, 2));
            Debug.WriteLine(PerCalPlus.GregorianDateToPersian("5/27/2015 3:14:25 PM"));
            Debug.WriteLine(PerCalPlus.GregorianDateToPersian(DateTime.Now));
            Debug.WriteLine(PerCalPlus.GregorianDateToPersianLong(DateTime.Now));


            Debug.WriteLine(PerCalPlus.PersianDateToGregorian(1366, 12, 2));
            Debug.WriteLine(PerCalPlus.PersianDateToGregorian(1366, 12, 2, 14, 22, 15));
            Debug.WriteLine(PerCalPlus.PersianDateToGregorian("1366/12/2", PerCalPlus.DateStringType.ToShortDateString));
            Debug.WriteLine(PerCalPlus.PersianDateToGregorian("1394/07/13 08:44:28 ب.ظ", PerCalPlus.DateStringType.Now));
            Debug.WriteLine(PerCalPlus.PersianDateToGregorian("دوشنبه - 2 اسفند - 1366", PerCalPlus.DateStringType.ToLongDateString));



            Debug.WriteLine(PerCalPlus.ShortYearToLongYear(66));
            Debug.WriteLine(PerCalPlus.ShortYearToLongYear("66"));



            Debug.WriteLine("");
            Debug.WriteLine("");
            Debug.WriteLine("");
            Debug.WriteLine("*********************************************************************************************************");


            Console.ReadLine();
        }
    }
}
