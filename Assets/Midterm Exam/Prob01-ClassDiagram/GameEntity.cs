using UnityEngine;

namespace MidtermExam.Prob01
{
    public class GameEntity
    {
        // TODO: Implement fields and methods according to Class Diagram
        string id;
        int health;
        Vector3 position;
        public void Update()
        {

        }

        public virtual void TakeDamage(int damage)
        {
            health -= damage;
        }

        private void Move(Vector3 direction)
        {
            position += direction;
        }
    }
}
