using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class WalkingState : ICharacterSate
    {
        public WalkingState() {
          Console.WriteLine("State changed  the character is Walking");
        }
        public void UpdateState(Character character,string state)
        {
            if (state == "Running")
                character.SetState(new Running());
            else if (state == "Idle")
                character.SetState(new IdleState());
        }
    }
}
