namespace InheritanceDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // single inheritance
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            // multi-level inheritance
            Horse horse = new Horse();
            horse.Eat();
            horse.run();
            horse.Gallop();

            // hierarchical inheritance
            Eagle eagle = new Eagle();
            Penguin penguin = new Penguin();
            eagle.Fly();
            eagle.Hunt();
            penguin.Fly();
            penguin.Swim();

            // multiple inheritance
            MyClass myClass = new MyClass();
            myClass.Method1();
            myClass.Method2();

            Console.ReadLine();
        }
    }
}
