using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Running : ICharacterSate
    {
        public Running() {
            Console.WriteLine("State changed  the character is Running");
        }
        public void UpdateState(Character character, string state)
        {
            if (state == "Walking")
                character.SetState(new WalkingState());
            else if (state == "Idle")
                character.SetState(new IdleState());
        }
    }
}
