// We are using interfaces to abstract away the methods regarding taking damage and healing to full,
// so that we can implement these methods via interfaces across all of our enemies or damageable objects

namespace Interfaces_Example
{
    public class EnemyOgre : IDamageable
    {// this is the Enemy Ogre class implementing the IDamageable Interface, forcing it to have the methods described in the interface
        private int health; // these variables are class-wide variables, they have a scope of the entire class as they can be used throughout any private methods, etc
        private int maxHealth;
        private float armorResistanceValue = 0.5f;
        private ElementType environmentElement;

        public EnemyOgre(int maxHealth, ElementType environmentElement)
        {
            this.maxHealth = maxHealth;
            health = this.maxHealth;
            this.environmentElement = environmentElement;
        }

        public void TakeDamage(int damage)  // Different from EnemyGoblin implementation of TakeDamage
        { // interfaces allow us to require certain methods be used but we can change the implementation of the methods.
            damage = (int)(damage * armorResistanceValue);

            health -= damage;
            Console.WriteLine($"due to resistance, damage was reduced to {damage} \n{this} has {health} health remaining");
        }
        public void HealToFull()
        {// set the current health value to the max health value ie.) A full heal
            float maxHealthModifier; // this is a method-wide variable, cannot be used outside the scope of HealToFull() Method

            if (environmentElement == ElementType.Fire)
            {
                maxHealthModifier = 0.5f;
                Console.WriteLine("The fire prevented the Ogre from healing fully");
            }
            else
            {
                maxHealthModifier = 1f;
            }

            health = (int)(maxHealth * maxHealthModifier);
        }

    }
}