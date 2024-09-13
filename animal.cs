using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace baitap{
    abstract class Animal
    {
       public abstract string MakeSound();
    }
    class Chicken : Animal, Edible
    {
        public override string MakeSound()
        {
            return "Chicken: cluck-cluck!";
        }
        public string HowToEat()
        {
            return "could be fried";
        }
    }
    class Tiger : Animal
    {
        public override string MakeSound()
        {
            return "Tiger: roarrrrr!";
        }
        
    }
    public interface Edible
    {
        public string HowToEat();
    }
}