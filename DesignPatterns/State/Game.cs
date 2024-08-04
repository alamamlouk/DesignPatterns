using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Game
    {
        Character character = new Character();
        bool exit = false;
        public void GameTime()
        {
            while (!exit)
            {
                Console.WriteLine("Enter the state of the character");
                string state = Console.ReadLine();
                if (state == "exit")
                {
                    exit = true;
                    break;
                }
                
                character.Update(state);
            }
        }
    }
}
