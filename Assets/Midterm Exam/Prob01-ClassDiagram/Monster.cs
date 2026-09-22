using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Monster
    {
        // TODO: Implement inheritance, fields and methods according to Class Diagram
        public int baseDamage;
        protected int aggroRange;

        public void Attack(GameEntity target) {
            target.TakeDamage(baseDamage);
        }
        protected virtual void Roar()
        {

        }
    }
}
