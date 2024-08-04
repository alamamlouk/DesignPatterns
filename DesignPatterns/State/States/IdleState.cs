using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class IdleState : ICharacterSate
    {
        public IdleState() {
            Console.WriteLine($"State changed  the character is Idle");
        }
        public void UpdateState(Character character,string state)
        {
            if(state == "Walking")
                character.SetState(new WalkingState());
            else if(state == "Running")
                character.SetState(new Running());
           
        }
    }
}
