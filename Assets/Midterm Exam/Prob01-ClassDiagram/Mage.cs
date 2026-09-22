using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Mage
    {
        // TODO: Implement inheritance, fields and methods according to Class Diagram

        public int mana;
        private int spellPower;
        public void Attack(GameEntity target)
        {
            target.TakeDamage(spellPower);
        }
        public void CastSpell(GameEntity target) 
        {
            Attack(target);
            mana--;
        }
    }
}
