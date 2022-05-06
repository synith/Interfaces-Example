// We are using interfaces to abstract away the methods regarding taking damage and healing to full,
// so that we can implement these methods via interfaces across all of our enemies or damageable objects


using Interfaces_Example;

EnemyGoblin gobbo = new EnemyGoblin(100);
EnemyGoblin gobbo2 = new EnemyGoblin(100);

EnemyOgre ogre = new EnemyOgre(500, ElementType.Fire);
EnemyOgre ogre2 = new EnemyOgre(500, ElementType.Wind);

List<IDamageable> enemies = new List<IDamageable>{ gobbo, gobbo2, ogre, ogre2 };

DoDamage(gobbo, 80); 
DoDamage(gobbo2, 50);
DoDamage(ogre, 400);
DoDamage(ogre2, 400);

foreach (var enemy in enemies)
    DoFullHeal(enemy);





Console.ReadKey();
// Program Ends Here

void DoDamage(IDamageable enemy, int damage)
{
    Console.WriteLine($"{enemy} took {damage} damage.");
    enemy.TakeDamage(damage);    
}

void DoFullHeal(IDamageable enemy)
{
    Console.WriteLine($"{enemy} healed to full health");
    enemy.HealToFull();    
}



