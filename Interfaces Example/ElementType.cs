// We are using interfaces to abstract away the methods regarding taking damage and healing to full,
// so that we can implement these methods via interfaces across all of our enemies or damageable objects

namespace Interfaces_Example
{
    public enum ElementType
    {// an enum is a special class that represents a collection of constant values, 
     //this is different from a list which is a collection of objects (that can have their own methods and variables)
        Fire,
        Wind,
        Water,
        Earth,
        None,
    }
}