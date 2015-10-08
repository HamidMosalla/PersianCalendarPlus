# PersianCalendarPlus
<h2>What is this?</h2>
PersianCalendarPlus is a simple wrapper around System.Globalization.PersianCalendar providing extra functionality such as different kind of date string in Persian and the ability to convert between them.
<h2>How do I install it?</h2>
You can install PersianCalendarPlus via <a href="https://www.nuget.org/packages/PersianCalendarPlus/">PersianCalendarPlus Nuget package</a>:
```
Install-Package PersianCalendarPlus 
```
<h2>Usage example</h2>
```C#
PerCalPlus.Now() => "1394/07/16 07:34:34 ب.ظ"

PerCalPlus.ToShortDateString() => "1394/07/16"

PerCalPlus.ToLongDateString() => "پنجشنبه - 16 مهر - 1394"



PerCalPlus.GetPersianYear() => "1394"

PerCalPlus.GetPersianYear(1988) => "1366"

PerCalPlus.GetPersianMonth() => "7"

PerCalPlus.GetPersianMonth(2, 21) => "12"

PerCalPlus.GetPersianDay() => "16"

PerCalPlus.GetPersianDay(1988, 2, 21) => "2"

PerCalPlus.GetDaysInPersianMonth(66, 12) => "30"

PerCalPlus.GetDaysInPersianYear(66) => "366"

PerCalPlus.GetDayOfWeekName() => "پنجشنبه"

PerCalPlus.GetDayOfWeekName(DateTime.Now.AddDays(2)) => "شنبه"

PerCalPlus.GetMonthName() => "مهر"

PerCalPlus.GetMonthName(DateTime.Now.AddDays(21)) => "آبان"



PerCalPlus.GregorianDateToPersian(1999, 8, 2) => "1378/05/11"

PerCalPlus.GregorianDateToPersian("5 / 27 / 2015 3:14:25 PM") => "1394/03/06"

PerCalPlus.GregorianDateToPersian(DateTime.Now) => "1394/07/16"

PerCalPlus.GregorianDateToPersianLong(DateTime.Now) => "پنجشنبه - 16 مهر - 1394"



PerCalPlus.PersianDateToGregorian(1366, 12, 2) => "2/21/1988 12:00:00 AM"

PerCalPlus.PersianDateToGregorian(1366, 12, 2, 14, 22, 15) => "2/21/1988 2:22:15 PM"

PerCalPlus.PersianDateToGregorian("1366 / 12 / 2", PerCalPlus.DateStringType.ToShortDateString) => "2/21/1988 12:00:00" AM

PerCalPlus.PersianDateToGregorian("1394 / 07 / 13 08:44:28 ب.ظ", PerCalPlus.DateStringType.Now) => "10/5/2015 12:00:00 AM"

PerCalPlus.PersianDateToGregorian("دوشنبه - 2 اسفند - 1366", PerCalPlus.DateStringType.ToLongDateString) => "2/21/1988 12:00:00 AM"



PerCalPlus.ShortYearToLongYear(66) => "1366"

PerCalPlus.ShortYearToLongYear("66") => "1366"

```
<h2>Converting from Gregorian date to Persian</h2>
There is two method that you can use for this purpose, if you want short date, you can use one of these three overload:
```C#
PerCalPlus.GregorianDateToPersian(1999, 8, 2) => "1378/05/11"

PerCalPlus.GregorianDateToPersian("5 / 27 / 2015 3:14:25 PM") => "1394/03/06"

PerCalPlus.GregorianDateToPersian(DateTime.Now) => "1394/07/16"
```
If you need long string date you can use:

```C# PerCalPlus.GregorianDateToPersianLong(DateTime.Now) => "پنجشنبه - 16 مهر - 1394"```
<h2>Converting from Persian date to Gregorian</h2>
There is one method for this with five overload, two of them take int as argument:
```C#
PerCalPlus.PersianDateToGregorian(1366, 12, 2) => "2/21/1988 12:00:00 AM"

PerCalPlus.PersianDateToGregorian(1366, 12, 2, 14, 22, 15) => "2/21/1988 2:22:15 PM"
```
The other three take a date string, note that use should specify what kind of date string you're supplying as argument through PerCalPlus.DateStringType enumeration, these three kind of string are the same as the one created by these three method:
```C#
PerCalPlus.Now() => "1394/07/16 07:34:34 ب.ظ"

PerCalPlus.ToShortDateString() => "1394/07/16"

PerCalPlus.ToLongDateString() => "پنجشنبه - 16 مهر - 1394"
```
In the enum part of method argument you should specify what kind of date string you want to supply as an argument, these three are PerCalPlus.DateStringType.ToShortDateString and PerCalPlus.DateStringType.Now and PerCalPlus.DateStringType.ToLongDateString which correspond to the aforementioned methods, note that the date string should conform to the format that produced previously by the PersianCalendarPlus or it doesn't going to work:
```C#
PerCalPlus.PersianDateToGregorian("1366 / 12 / 2", PerCalPlus.DateStringType.ToShortDateString) => "2/21/1988 12:00:00" AM

PerCalPlus.PersianDateToGregorian("1394 / 07 / 13 08:44:28 ب.ظ", PerCalPlus.DateStringType.Now) => "10/5/2015 12:00:00 AM"

PerCalPlus.PersianDateToGregorian("دوشنبه - 2 اسفند - 1366", PerCalPlus.DateStringType.ToLongDateString) => "2/21/1988 12:00:00 AM"
```
