using System;

namespace Age_Calculator_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int year, byear, tyear, month, bmonth, tmonth, date, bdate, tdate;
            tyear = tmonth = tdate = 0;
            int[] adate = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            String sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));

            date =Int32.Parse( datevalue.Day.ToString());
            month =Int32.Parse( datevalue.Month.ToString());
            year =Int32.Parse( datevalue.Year.ToString());
            Console.WriteLine("Current Year {0} Month {1} date {2}",year,month,date);


            /*Console.Write("Enter Year:");
            year=int.Parse(Console.ReadLine());
            Console.Write("Enter Month:");
            month = int.Parse(Console.ReadLine());
            Console.Write("Enter Date:");
            date = int.Parse(Console.ReadLine());
            */

            Console.Write("Enter Birth Year:");
            byear = int.Parse(Console.ReadLine());
            Console.Write("Enter Birth Month:");
            bmonth = int.Parse(Console.ReadLine());
            Console.Write("Enter Birth Date:");
            bdate = int.Parse(Console.ReadLine());

            if (bmonth > month)
            {
                tyear--;
                tmonth = (month + 12) - bmonth;
            }
            else
                tmonth = month - bmonth;
            if (bdate > date)
            {
                tmonth--;
                tdate = (date + adate[tmonth + 1]) - bdate;
            }
            else
                tdate = date - bdate;
            if (year > byear)
            {
                tyear = year - byear;
            }
            else
            {
                Console.WriteLine("Wrong");
            }

            if (month <= 12 && bmonth <= 12)
            { }
            else
            {
                Console.WriteLine("Wrong");
            }

            if (date > adate[month])
            {
                Console.WriteLine("Wrong");
            }
            Console.WriteLine(" Your age is : " +tyear + " Year " + tmonth + " Month " + tdate + " Date ");
            


            Console.ReadKey();
        }
    }
}
