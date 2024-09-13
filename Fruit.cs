namespace baitap{
    abstract class Fruit{
       public abstract string HowToEat();
    }
    class Apple : Fruit
    {
        public override string HowToEat()
    {
        return "Apple could be slided";
    }
    }
    class Orange : Fruit
    {
        public override string HowToEat()
        {
            return "Orange could be juiced";
        }
    }
}