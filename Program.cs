using System.Text;

string[] techniques = { "   C#", "daTAbaser", "WebbuTVeCkling ", "clean Code   " };

string kurser = "";
kurser = courseGenerator(techniques);

string courseGenerator(string[] techniques)
{
    foreach (string technique in techniques)
    {
        string tmp = technique.Trim();
        kurser += "<p>" + tmp[0].ToString().ToUpper() +
        tmp.Substring(1).ToLower() + "</p>\n";
    }
    return kurser;
}
Console.WriteLine(kurser);

Console.WriteLine("----------------------------------");
//Diskutera hur det ska gå till och skriv om denna så att
//den använder en Aggregator.


string fixedTechniques = techniques.Aggregate("", (a, b) =>
{
    b = b.Trim();
    b = "<p>" + b[0].ToString().ToUpper() + b.Substring(1).ToLower() + "</p>\n";
    return a + b;
});Console.WriteLine(fixedTechniques);Console.WriteLine("----------------------------------");
List<Monster> monsterList = new List<Monster>(){new Monster("Gromp", 100, false),
                                                new Monster("Cranky", 120, true),
                                                new Monster("CoffeeSpiller", 35, false)};

//1.Använd SELECT och FOREACH för att skriva ut alla namn på monstrena (det är en bra
//ide att lägga in alla monsternamn i en var eller List<string> om ni vill ha en
//temporär variabel).

monsterList.Select(m => m.Name).ToList().ForEach(m => Console.WriteLine(m));

// Eller

var monsterNames = from monster in monsterList
                   select monster.Name;

foreach (var name in monsterNames)
{
    Console.WriteLine(name);
}

Console.WriteLine("---------------------------------");


//2.Använd WHERE, SELECT och FOREACH för att skriva ut alla monster med mer än 50
//health.
monsterList.Where(m => m.Health > 50).ToList().ForEach(monster => Console.WriteLine(monster.Name + " " + monster.Health));

// Eller

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

// Eller

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

// Eller

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





