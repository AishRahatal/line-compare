using System;
using System.Collections.Generic;
using System.Text;

namespace line_compare
{
    class Calculate_length
    {
        public void get_length()
        {
            //A Length as 2 Points (x1, y1) and (x2, y2) 
            
                // Taking input from user
             //------first line 
            Console.WriteLine("Enter two co-ordinates for first line :");
                Console.WriteLine("Enter first co-ordinate of first point x1 :"); 
                int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second co-ordinate of first point x2:");
                int x2= Convert.ToInt32(Console.ReadLine());
    
           Console.WriteLine("Enter first co-ordinate of first point y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second co-ordinate of first point y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("value of first line co-ordinates :");
            Console.WriteLine(" x1 =" + x1.ToString());
            Console.WriteLine(" x2 =" + x2.ToString());
            Console.WriteLine(" y1 =" + y1.ToString());
            Console.WriteLine(" y2 =" + y2.ToString());
            Console.ReadKey();
            Console.WriteLine("--------------------------------------------");
            
            //------second line 
            Console.WriteLine("Enter two co-ordinates for second line :");
            Console.WriteLine("Enter first co-ordinate of second point x1 :");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second co-ordinate of second point x2:");
            int a2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter first co-ordinate of second point y1:");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second co-ordinate of second point y2:");
            int b2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("value of second line co-ordinates :");
            Console.WriteLine(" x1 =" + a1.ToString());
            Console.WriteLine(" x2 =" + a2.ToString());
            Console.WriteLine(" y1 =" + b1.ToString());
            Console.WriteLine(" y2 =" + b2.ToString());
            Console.ReadKey();
            Console.WriteLine("----------------------------------------");


            //mathematical operation for length ,Length of a Line = sqrt( (x2 - x1) ^ 2 + (y2-y1) ^2)

            double len1 = Math.Sqrt((Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2))); 

            Console.WriteLine("Length of first line :" +len1);

            double len2 = Math.Sqrt((Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2)));

            Console.WriteLine("Length of second line :" + len2);

            Console.WriteLine("------------------------");

            //checking equality of lenths  using Equals method

            bool status = len1.Equals(len2); 
            if (status)
                Console.WriteLine("first line is equal to second line}", len1, len2);
            else
                Console.WriteLine("first line is not equal to second line", len1, len2);
            
            Console.WriteLine("------------------------");

            // using CompareTo() method
            int cmp = len1.CompareTo(len2);

            // checking the status
            if (cmp > 0)
                Console.WriteLine("first line is greater than second line",len1, len2);
            else if (cmp < 0)
                Console.WriteLine("first line is less than second line",len1, len2);
            else
                Console.WriteLine("first line is equal to second line",len1, len2);

            Console.ReadKey();


        }


    }
}
