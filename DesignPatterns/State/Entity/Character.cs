using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Character
    {
        private ICharacterSate _state;
        public Character()
        {
            _state = new IdleState();
        }
        public void SetState(ICharacterSate state)
        {
            _state = state;
        }
        public void Update(string state)
        {
            _state.UpdateState(this,state);
        }
    }
}
