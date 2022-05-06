// We are using interfaces to abstract away the methods regarding taking damage and healing to full,
// so that we can implement these methods via interfaces across all of our enemies or damageable objects

namespace Interfaces_Example
{
    public interface IDamageable
    {// an interface is a collection of methods that must be used when a class implements that interface (similar to inheritance)
        public void TakeDamage(int damage);
        public void HealToFull();
    }
}