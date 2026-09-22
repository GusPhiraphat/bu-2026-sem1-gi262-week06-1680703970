using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Weapon
    {
        // TODO: Implement inheritance, fields and methods according to Class Diagram

        public int extraDamage;
        private float criticalChance;

        public Equipment equipment;

        public void Equip(Hero hero)
        {

        }
        public void Polish()
        {
            equipment.durability++;
        }

    }
}
