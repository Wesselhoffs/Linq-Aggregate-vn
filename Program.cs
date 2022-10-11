                                        List<Monster> monsterList = new List<Monster>(){new Monster("Gromp", 100, false),
                                                new Monster("Cranky", 120, true),
                                                new Monster("CoffeeSpiller", 35, false)};
      //1.Använd SELECT och FOREACH för att skriva ut alla namn på monstrena (det är en bra
//ide att lägga in alla monsternamn i en var eller List<string> om ni vill ha en
//temporär variabel).

monsterList.Select(m => m.Name).ToList().ForEach(m => Console.WriteLine(m));



var tempVar = from monster in monsterList
              select monster.Name;

foreach (var name in tempVar)
{
    Console.WriteLine(name);
}

Console.WriteLine("---------------------------------");


//2.Använd WHERE, SELECT och FOREACH för att skriva ut alla monster med mer än 50
//health.
monsterList.Where(m => m.Health > 50).ToList().ForEach(monster => Console.WriteLine(monster.Name + " " + monster.Health));

var monsterWithHealtoverFifty = from monster in monsterList
                                where monster.Health > 50
                                select monster;
foreach (var monster in monsterWithHealtoverFifty)
{
    Console.WriteLine($"{monster.Name} {monster.Health}");
}

Console.WriteLine("---------------------------------");


//3. Använd WHERE, SELECT och FOREACH för att skriva ut alla monster som inte är
//döda.

monsterList.Where(m => m.isDead == false).ToList().ForEach(m => Console.WriteLine(m.Name + " is not dead"));

var notDead = from monster in monsterList
              where monster.isDead == false
              select monster;

foreach (var monster in notDead)
{
    Console.WriteLine($"{monster.Name} is not dead");
}

Console.WriteLine("---------------------------------");


//4. Använd SELECT, ORDERBY och FOREACH för att skriva ut alla namn i ascending
//order.

monsterList.OrderBy(m => m.Name).ToList().ForEach(m => Console.WriteLine(m.Name));
monsterList.OrderByDescending(m => m.Name).ToList().ForEach(m => Console.WriteLine(m.Name));

var ascendingMonsters = from monster in monsterList
                      orderby monster.Name ascending
                      select monster;

var descendingMonsters = from monster in monsterList
                         orderby monster.Name descending
                         select monster;



Console.WriteLine("---------------------------------");

class Monster
{
    public string Name { get; set; }
    public int Health { get; set; }
    public bool isDead { get; set; }
    public Monster(string name,
    int health, bool isDead)
    {
        Name = name;
        Health = health;
        this.isDead = isDead;
    }
}