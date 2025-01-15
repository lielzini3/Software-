using System;

namespace MeshimaLehagash20
{
    internal class ProgramBase1
    {
        static void Main(string[] args)
        {
            //    //דף תרגילים - סעיף1
            //    int maxPrice = 0; 
            //    for (int i = 1; i <= 5; i++)
            //    {
            //        Console.Write("enter the price of the phone" + i + ": ");
            //        int price = int.Parse(Console.ReadLine());

            //        // המחיר היקר ביותר
            //        if (price > maxPrice)
            //        {
            //            maxPrice = price;
            //        }
            //    }

            //    //  המחיר היקר ביותר
            //    Console.WriteLine("the most expensive phone cost: " + maxPrice);
            //}

            // דף תרגילים- סעיף 2
            Random rand = new Random();  // הגדרת אובייקט Random מחוץ ללולאה
            int minNum = 99;  // אתחול לערך הגבוה ביותר אפשרי (99)
            int maxNum = 10;  // אתחול לערך הנמוך ביותר אפשרי (10)

            // גרילת 100 מספרים דו-סיפרתיים
            for (int i = 1; i <= 100; i++)
            {
                int number = rand.Next(10, 100);  // גרילה של מספר דו-סיפרתי בין 10 ל-99

                // חישוב המספר הקטן ביותר והגדול ביותר
                if (number < minNum)
                {
                    minNum = number;
                }
                if (number > maxNum)
                {
                    maxNum = number;
                }
            }

            // הדפסת התוצאות
            Console.WriteLine("The smallest number drawn is: " + maxNum);
            Console.WriteLine("The largest number drawn is: " + minNum);
    }
}