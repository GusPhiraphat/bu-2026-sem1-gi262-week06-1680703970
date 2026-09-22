using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Hero
    {
        // TODO: Implement inheritance, fields and methods according to Class Diagram

        public int currentExp;
        private int gold;

        public void Attack(GameEntity target)
        {

        }

        public void CollectGold(int amount)
        {
            gold += amount;
        }

        protected void LevelUp()
        {
            currentExp = 0;
        }
    }
}
