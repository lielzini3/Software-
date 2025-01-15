using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeshimaLehagash20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // דף תרגילים - סעיף 1
            // int maxPrice = 0; 
            // for (int i = 1; i <= 5; i++)
            // {
            //     Console.Write("enter the price of the phone " + i + ": ");
            //     int price = int.Parse(Console.ReadLine());

            //     // המחיר היקר ביותר
            //     if (price > maxPrice)
            //     {
            //         maxPrice = price;
            //     }
            // }

            // //  המחיר היקר ביותר
            // Console.WriteLine("the most expensive phone cost: " + maxPrice);

            // דף תרגילים - סעיף 2
            // Random rand = new Random();  // הגדרת אובייקט Random מחוץ ללולאה
            // int minNum = 99;  // אתחול לערך הגבוה ביותר אפשרי (99)
            // int maxNum = 10;  // אתחול לערך הנמוך ביותר אפשרי (10)

            // // גרילת 100 מספרים דו-סיפרתיים
            // for (int i = 1; i <= 100; i++)
            // {
            //     int number = rand.Next(10, 100);  // גרילה של מספר דו-סיפרתי בין 10 ל-99

            //     // חישוב המספר הקטן ביותר והגדול ביותר
            //     if (number < minNum)
            //     {
            //         minNum = number;
            //     }
            //     if (number > maxNum)
            //     {
            //         maxNum = number;
            //     }
            // }

            // // הדפסת התוצאות
            // Console.WriteLine("The smallest number drawn is: " + maxNum);
            // Console.WriteLine("The largest number drawn is: " + minNum);

            // דף תרגילים - סעיף 3
            double minArea = double.MaxValue;  // אתחול לשטח המלבן הגדול ביותר אפשרי

            // קלט שיעורי הנקודות עבור 10 מלבנים
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("הכנס את שיעורי הנקודות עבור המלבן " + i);

                // קלט של הנקודות
                Console.Write("שיעור הנקודה השמאלית התחתונה X: ");
                double x1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("שיעור הנקודה השמאלית התחתונה Y: ");
                double y1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("שיעור הנקודה הימנית העליונה X: ");
                double x2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("שיעור הנקודה הימנית העליונה Y: ");
                double y2 = Convert.ToDouble(Console.ReadLine());

                // חישוב שטח המלבן
                double area = (x2 - x1) * (y2 - y1);
                if (area < 0) area = -area;  // הופך שטח שלילי לחיובי

                // עדכון השטח הקטן ביותר
                if (area < minArea)
                {
                    minArea = area;
                }
            }

            // הדפסת שטח המלבן הקטן ביותר
            Console.WriteLine("שטח המלבן הקטן ביותר הוא: " + minArea);
        }
    }
}
