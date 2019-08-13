/*
 * Name: (Esther)
 *C# app to simulate a Hollywood Movie Rating.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRating
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie myMovie1 = new Movie();
            int numOfTries = 0;
            int mstar = 0;
            int mtotalStars = 0;
            double count = 0;
            int i = 0;
            int choice = 0;
            string strgInput;
            string strgInput2;

            Console.WriteLine("\t\tName: Esther\n");
            Console.WriteLine("\t\tThe Movie Rating Application. \n\t\tYou have 3 attempts of failure. ");
            Console.Write("\t\tEnter the title of the movie:   ");
            myMovie1.Ctitle = Console.ReadLine();
            Console.Write("\n");

            do
            {
                Console.Write("\tPlease rate the movie from 0 to 4 stars:   ");
                strgInput = Console.ReadLine();//get user rating as a string
                //mstar = Convert.ToInt16(strgInput);
                if(int.TryParse(strgInput, out mstar))
                {
                    //Console.WriteLine("\t\t\t\t\t\t\t\tThanks!");
                }
                else
                {
                    while(!int.TryParse(strgInput, out mstar))
                    {
                        Console.Write("\tPlease enter a number from 0 to 4  to rate the moviestars:   ");
                        strgInput = Console.ReadLine();//get user rating as a string
                    }
                }

                if ((mstar > 0 && mstar < 5))//when input ie correct
                {
                    count++;
                    myMovie1.Cstar = mstar;
                    mtotalStars += mstar;//the total of a movie stars
                    Console.WriteLine("\n\t\tYour rating of  {0} is:   {1} the count is: {2} ", myMovie1.Ctitle, myMovie1.Cstar, count);
                    Console.WriteLine("\t\tThe average stars rating of the {0} is:   {1}", myMovie1.Ctitle, (mtotalStars / count));

                    //mstar = Convert.ToInt16(strgInput);
                    //choice = Convert.ToInt16(Console.ReadLine());
                    Console.Write("\nEnter negative number to quit. \nDo you want to continue?   ");
                    strgInput2 = Console.ReadLine();//get user choice as a string
                    //Convert user's choice into int
                    if (int.TryParse(strgInput2, out choice))
                    {
                        //Console.WriteLine("\t\t\t\t\t\t\t\tThank you for continuing");
                    }
                    else
                    {
                        while (!int.TryParse(strgInput2, out choice))
                        {
                            Console.Write("\nPlease enter a number or a negative number to quit. \nDo you want to continue?   ");
                            strgInput2 = Console.ReadLine();//get user rating as a string
                        }
                    }
                }
                else if (mstar < 0 || mstar > 4 && i < 4)//when input is wrong
                {
                    Console.WriteLine("\n \t\t\tInvalide number!!! \n\t\t\tPlease enter a numer between 0 and 4. !!!");
                    i++;
                    if(i < 4)
                    {
                        Console.Write("\nNumber of attempt = {0} ", i);
                        Console.Write("\nEnter negative number to quit. \n\tDo you want to continue?   ");
                        //choice = Convert.ToInt16(Console.ReadLine());
                        strgInput2 = Console.ReadLine();//get user choice as a string
                                                        //Convert user's choice into int
                        if (int.TryParse(strgInput2, out choice))
                        {
                            //Console.WriteLine("\t\t\t\t\t\t\t\tThank you for continuing");
                        }
                        else
                        {
                            while (!int.TryParse(strgInput2, out choice))
                            {
                                Console.Write("\nPlease enter a number or a negative number to quit. \nDo you want to continue?   ");
                                strgInput2 = Console.ReadLine();//get user rating as a string
                            }
                        }
                    }
                    else if (i == 4)
                    {
                        Console.Write("\n\t\t\t!!!  You have reach the number of failure. Good bye! ");
                        break;
                    }
                }
            } while (choice > 0 && i < 4);//End of do while do do do do do do 

            Console.WriteLine("\n\n\t\tThe total stars rating of the {0} is:   {1} the number of ratings is {2}", myMovie1.Ctitle, (mtotalStars), count);
            Console.WriteLine("\t\tThe average stars rating of the {0} is:   {1}", myMovie1.Ctitle, (mtotalStars / count));
            Console.Write("\n");
        }//End of Main m m m m m m m m 
       
    }//End of class class class class
}//End of namespace namespace namespace


