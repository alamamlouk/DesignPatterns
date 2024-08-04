using System;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while(!exit)
            {
                Console.WriteLine("Choose the Design Pattern  to try");
                Console.WriteLine("1. Prototype");
                Console.WriteLine("2. Builder");
                Console.WriteLine("3. Singleton");
                Console.WriteLine("4. Adapter");
                Console.WriteLine("5. Bridge");
                Console.WriteLine("6. Decorator");
                Console.WriteLine("7. State");
                Console.WriteLine("8. Strategy");
                Console.WriteLine("9. Observer");
                Console.WriteLine("10. Exit");
                int number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Prototype.Program prototype = new Prototype.Program();
                        prototype.MakeCopies();
                        break;
                    case 2:
                        Builder.Program builder = new Builder.Program();
                        builder.BuildCar();
                        break;
                    case 3:
                        Singleton.Program singleton = new Singleton.Program();
                        singleton.SingletonProgram();
                        break;
                    case 4:
                        Adapter.Program adapter = new Adapter.Program();
                        adapter.Pay();
                        break;
                    case 5:
                        Bridge.Program bridge = new Bridge.Program();
                        bridge.Darw();
                        break;
                    case 6:
                        Decorator.Program decorator = new Decorator.Program();
                        decorator.MakeLablebi();
                        break;
                    case 7:
                        State.Game game = new State.Game();
                        game.GameTime();
                        break;
                    case 8:
                        Strategy.Program strategy = new Strategy.Program();
                        strategy.Compress();
                        break;
                    case 9:
                        Observer.Program observer = new Observer.Program();
                        observer.Publish();
                        break;
                    case 10:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Design Pattern");
                        break;
                }
            }
            
        }
    }
}
