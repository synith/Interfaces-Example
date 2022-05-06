// We are using interfaces to abstract away the methods regarding taking damage and healing to full,
// so that we can implement these methods via interfaces across all of our enemies or damageable objects

namespace Interfaces_Example
{
    public class EnemyGoblin : IDamageable
    {// this is the Enemy Goblin class implementing the IDamageable Interface, forcing it to have the methods described in the interface
        private int health; // these variables are class-wide variables, they have a scope of the entire class as they can be used throughout any private methods, etc
        private int maxHealth;

        public EnemyGoblin(int maxHealth)
        {
            this.maxHealth = maxHealth;
            health = this.maxHealth;
        }

        public void TakeDamage(int damage) // Different from EnemyOgre implementation of TakeDamage
        {
            health -= damage;
            Console.WriteLine($"{this} has {health} health remaining");
        }
        public void HealToFull()
        {// set the current health value to the max health value ie.) A full heal
            health = maxHealth;
        }
    }
}