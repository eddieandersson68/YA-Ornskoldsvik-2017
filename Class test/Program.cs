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
        public List<T> _list = new List<T>();
        public void AddToList(T x)
        {
            _list.Add(x);
        }

        public void PrintAnimals()
        {
            foreach (T i in _list)
            {
                Console.WriteLine(i);
            }
        }

    }
    

    class Program
    {
        
        static void Main(string[] args)
        {
           
            Animals<Dog> myDogs = new Animals<Dog>();
            myDogs.AddToList(new Dog(){ Age = 7, Name = "Lassie" });
            myDogs.AddToList(new Dog() { Age = 12, Name = "Bob" });


            
            myDogs.PrintAnimals();
            AgeClass a1 = new AgeClass();
           

            a1.Age(7);
            Console.ReadLine();
        }
    }
}
