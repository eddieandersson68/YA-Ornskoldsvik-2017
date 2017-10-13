using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal;
namespace Class_test
{
    class Animals<T>
    {
        public List<T> _animal = new List<T>();
        public void AddToList(T x)
        {
            _animal.Add(x);
        }

        public void PrintAnimals()
        {
            foreach (T i in _animal)
            {
                Console.WriteLine(i);
            }
        }

    }
    

    class Program
    {
        
        static void Main(string[] args)
        {
            
            List<Dog> myDogs = new List<Dog>();
            myDogs.Add(new Dog(){ Age = 7, Name = "Lassie" });


            foreach (Dog dogs in myDogs)
            {
                Console.WriteLine(dogs);
            }

            //myDogs.PrintAnimals();

            AgeClass a1 = new AgeClass();
            //Cat myCat = new Cat();
            //Dog d1 = new Dog();

            //myCat.Description();
            

            a1.Age(7);

            //d1.DoggyStyle();
            Console.ReadLine();
        }
    }
}
