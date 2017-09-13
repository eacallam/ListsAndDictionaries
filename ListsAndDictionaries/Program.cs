using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> faveFoods = new List<string>() { "pizza", "alfredo", "chicken", "sushi", "broccoli"};
            //print out a list item
            Console.WriteLine(faveFoods[0]); //(index starts at 0)
            Console.WriteLine(faveFoods[4]);

            
            //if we don't know the info we want to add ahead of time...

            List<int> luckyNumbers = new List<int>();

            //to add numbers to this list,

            luckyNumbers.Add(13);
            luckyNumbers.Add(14);
            luckyNumbers.Add(27);
            luckyNumbers.Add(3);

            //new list
            List<string> badFoods = new List<string>();

            //If you put something else in one of these index locations later, it will be replaced.
            //for and for each loops are useful to use with these to print off information

            List<string> faveFilms = new List<string>() { "Wall-E", "Superman", "Casablanca" };

            //We are going to use a for loop and the Count method to print the items,

            for (int counter = 0; counter < faveFilms.Count; counter++)  //.Count represents the length of the list
            {
                Console.WriteLine(faveFilms[counter]);
            }

            //same result, different approach using a foreach loop,
            foreach (string film in faveFilms)
            {
                Console.WriteLine(film);
            }

            //.Remove method to remove an item from the list (this is case sensitive)
            faveFilms.Remove("Casablanca");
            faveFilms.Remove("Wall-E");

            //To add an item to a specific spot in a list,
            faveFilms.Insert(0, "Chitty Chitty Bang!");

            //Checking remaining items:
            foreach (string film in faveFilms)
            {
                Console.WriteLine(film);
            }

            //PRACTICE
            //Create a list with five animals using the .Add()
            //Print each animal in the list

            List<string> faveAnimals = new List<string>();
            faveAnimals.Add("Zebra");
            faveAnimals.Add("Giraffe");
            faveAnimals.Add("Puppy");
            faveAnimals.Add("Panda");
            faveAnimals.Add("Penguin");

            foreach (string animal in faveAnimals)
            {
                 Console.WriteLine(animal);
            }

            //Create the following list:
            //List boolList = new List() { true, false, false, true, false };
            //Loop through each value
            //If the value is true print: "Better bring an umbrella"
            //If the value is false print: "No rain today, enjoy the sun!"

            List<bool> boolList = new List<bool>() { true, false, false, true, false };

            foreach (bool answer in boolList)
            {
                if(answer == true)
                {
                    Console.WriteLine("Better bring an umbrella");
                }

                else
                {
                    Console.WriteLine("No rain today, enjoy the sun!");
                }
            }

            //can also use a for loop
            for (int counter = 0; counter < boolList.Count; counter++)
                if (boolList[counter] == true)
                {
                    Console.WriteLine("Better bring an umbrella");
                }

                else
                {
                    Console.WriteLine("No rain today, enjoy the sun!");
                }

            //Create a list with the following numbers: 1, 23, 9, 77, 922, 6, 32, 63, 14, 5
            //Use the .Contains() method with the following values 23, 77, 15
            //Remove the 4 elements 27, 77, 32 and 6
            //Use the .Contains() method with the following values 23, 77, 15

            List<int> numberList = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };

            Console.WriteLine(numberList.Contains(23));
            Console.WriteLine(numberList.Contains(77));
            Console.WriteLine(numberList.Contains(15));

            numberList.Remove(27);
            numberList.Remove(77);
            numberList.Remove(32);
            numberList.Remove(6);

            Console.WriteLine(numberList.Contains(23));
            Console.WriteLine(numberList.Contains(77));
            Console.WriteLine(numberList.Contains(15));

            //LIST PROPERTIES & METHODS

            //Count: Property of list that gives length of list.

            Console.WriteLine(numberList.Count());

            //Clear: Method of list that clears out the whole list
            numberList.Clear();
            Console.WriteLine(numberList.Count());


            //Add: add elements to list

            //Remove: remove elements from list

            //Sort: puts elements in order

            //IndexOf: you can find the index location of an element

            //Contains: boolean return regarding whatever element you give it

            //RemoveAt: remove element at particular index

            //Insert: name the index point of insertion and what you want to insert

            //Reverse?? 


            //DICTIONARIES
            Dictionary<int, string> coatCheck = new Dictionary<int, string>()
            {
                { 23, "yellow jacket" },
                { 14, "blue coat" },
                { 3, "white trench" } ,
                { 5, "black blazer" },
                { 9, "blue coat" },
                { 16, "sweatshirt" },
            };
            
            foreach (KeyValuePair<int, string> item in coatCheck)
                Console.WriteLine(item); ;

            //DICTIONARY METHODS
            //Add
            //ContainsKey
            //ContainsValue
            //TryGetValue
            //Remove
            //Clear
            //Key
            //Value
            //Count
        

            //Count
            Console.WriteLine(coatCheck.Count());

            //Print only keys
            foreach (KeyValuePair<int, string> coat in coatCheck)
            {
                Console.WriteLine(coat.Key);
            }

            //Print the values
            foreach (KeyValuePair<int, string> coat in coatCheck)
            {
                Console.WriteLine(coat.Value);
            }

            //PRACTICE
            //Create a dictionary for a car valet service with 10 cars. 
            //The key will be the customer’s last name and the value will be the car make.
            //Print all the elements to the console.

            Dictionary<string, string> carValet = new Dictionary<string, string>()
            {
                { "Callam", "Chevrolet"},
                { "Smith", "Ford"},
                { "Bob", "Cadillac"},
                { "Johnson", "Honda" },
                { "McDowell", "Ford" },
                { "Brown", "Chevrolet" },
                { "McCormick", "Mitsubishi" },
                { "Char", "Honda" },
                { "Midei", "Ford" },
                { "Moeien", "Toyota" },
            };

            foreach (KeyValuePair<string,string> car in carValet)
            {
                Console.WriteLine(car);
            }


            //Create a dictionary of 10 zoo animals. The key will be the animal type and the value will be the number of animals at the zoo.
            //Remove the zoo animal with the lowest quantity from the dictionary using the Remove method.
            //Use the Count Property to count the number of remaining entries in the dictionary. Print to the console.
            Dictionary<string, int> zooInventory = new Dictionary<string, int>()
            {
                { "Elephant", 20 },
                { "Quokka", 12 },
                { "Hippo", 5 },
                { "Giraffe", 2 },
                { "Kangaroo", 1 },
                { "Panda", 8 },
                { "Koala", 10 },
                { "Mouse", 7 },
                { "Snake", 30 },
                { "Tarantula", 4 }
            };

            zooInventory.Remove("Kangaroo");

            Console.WriteLine(zooInventory.Count());

            //Create a program that allows a user to input an animal name to check to see if the dictionary contains that animal name.
            //If the animal name does not exist in the dictionary, ask the user if s/he would like to add it. If so, add the animal to the dictionary.

            Console.WriteLine("Please enter an animal and I'll tell you if it's in the dictionary.");
            string userAnimal = Console.ReadLine();
            if (zooInventory.ContainsKey(userAnimal) == false)
            {
                Console.WriteLine("Would you like to add this animal to the dictionary? Type 'yes' if so.");
                string userAddAnswer = Console.ReadLine();
                if (userAddAnswer.ToLower() == "yes")
                    zooInventory.Add(userAnimal, 0);
            }

            Console.WriteLine(zooInventory.Count());
            
        }
    }
}
