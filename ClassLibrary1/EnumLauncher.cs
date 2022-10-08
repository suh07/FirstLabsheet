using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class EnumLauncher
    {
        public static void Display()
        {
            int previousCat = 0;
            foreach (var category in Enum.GetValues(typeof(Category)))
            {
                Console.WriteLine("Category " + category + " has the range of " + previousCat + " - " + (int)category);
                previousCat = (int)category + 1;

            }
        }
        public static void Launch()
        {
            int userInput = 0;

            do {
                Display();

                Console.Write("Please enter a value: ");
                userInput = int.Parse(Console.ReadLine());

                if (userInput == -1)
                    break;
                

                Category userCat = new Category();
                int previousCat=0; 

                foreach (var category in Enum.GetValues(typeof(Category)))
                {
                   
                    if (userInput >= previousCat && userInput <= (int)category)
                    {
                        userCat = (Category)category;
                        break;
                    }
                    previousCat = (int)category + 1;

                }
               
                Console.WriteLine("Your category: "+ userCat);
               

            }while(userInput != -1);

            
        }
    }
}
