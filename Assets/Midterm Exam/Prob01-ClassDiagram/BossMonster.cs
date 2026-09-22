using UnityEngine;

namespace MidtermExam.Prob01
{
    public class BossMonster
    {
        // TODO: Implement inheritance, fields and methods according to Class Diagram

        public int phase;
        private bool isEnraged;
        public void Attack(GameEntity target)
        {

        }
        protected void Roar()
        {

        }
        public void TriggerPhaseTransition()
        {
            phase++;
            isEnraged = true;
        }
    }
}
