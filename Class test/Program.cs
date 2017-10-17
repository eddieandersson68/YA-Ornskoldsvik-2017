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

            Animals<AnimalTypes> myAnimals = new Animals<AnimalTypes>();

            myAnimals.AddToList(new Dog() { Speices = "Dog", Breed = "German Shepard", Hight = 65, Length = 97, Age = 6, Name = "Rocky", Tail = 66 });
            myAnimals.AddToList(new Dog() { Speices = "Dog", Breed = "Golden Retriver", Hight = 75, Length = 103, Age = 8, Name = "Boomer",Tail = 70 });


            myAnimals.AddToList(new Cat() { Speices = "Cat", Breed = "Burma", Hight = 24, Length = 53, Age = 3, Name = "whitey" });
            myAnimals.AddToList(new Cat() { Speices = "Cat", Breed = "Norveigan", Hight = 33, Length = 57, Age = 5, Name = "Doris" });

            myAnimals.PrintAnimals();

            Console.Write("Wow Rocky ");
            myAnimals._list.Where(x => x.Name == "Rocky").FirstOrDefault().PrintHumanAge();
            Console.Write("Doris ");
            myAnimals._list.Where(x => x.Name == "Doris").FirstOrDefault().PrintHumanAge();


            myAnimals._list.Find(x => x.Name == "r");

            
           
            Console.ReadLine();
        }
    }
}
