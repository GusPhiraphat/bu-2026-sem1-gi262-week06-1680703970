using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Warrior
    {
        // TODO: Implement inheritance, fields and methods according to Class Diagram
   
        public int shieldDefense;
        private float rage;
        public void Attack(GameEntity target)
        {

        }
        public void ShieldBash(GameEntity target)
        {
            target.TakeDamage(1);
        }
    }
}
