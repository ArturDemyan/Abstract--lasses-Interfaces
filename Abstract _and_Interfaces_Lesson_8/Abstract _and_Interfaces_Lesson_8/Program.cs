using System.Text;
using System.Xml.Linq;

namespace Abstract__and_Interfaces_Lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine("what is your dog's name?");
            dog.Name = Console.ReadLine(); 
            dog.SetName(dog.Name);

            Console.WriteLine("what is your dog's eat?");
            dog.Eat = Console.ReadLine().ToString();
            dog.Eat(dog.Eat);
           
            var whatNameDog = dog.GetName();
        }
    }
}
