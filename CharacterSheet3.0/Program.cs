Console.WriteLine("    _____         ___________        ____________      ____________       _____         ");
Console.WriteLine("  /      |_       \\          \\       \\           \\    /            \\    /      |_       ");
Console.WriteLine(" /         \\       \\    /\\    \\       \\           \\  |\\___/\\  \\___/|   /         \\      ");
Console.WriteLine("|     /\\    \\       |   \\_\\    |       |    /\\     |  \\|____\\  \\___|  |     /\\    \\     ");
Console.WriteLine("|    |  |    \\      |      ___/        |   |  |    |        |  |      |    |  |    \\    ");
Console.WriteLine("|     \\/      \\     |      \\  ____     |    \\/     |   __  /   / __   |     \\/      \\   ");
Console.WriteLine("|\\      /\\     \\   /     /\\ \\/    \\   /           /|  /  \\/   /_/  |  |\\      /\\     \\  ");
Console.WriteLine("| \\_____\\ \\_____\\ /_____/ |\\______|  /___________/ | |____________/|  | \\_____\\ \\_____\\ ");
Console.WriteLine("| |     | |     | |     | | |     | |           | /  |           | /  | |     | |     | ");
Console.WriteLine(" \\|_____|\\|_____| |_____|/ \\|_____| |___________|/   |___________|/   |_|_____| |_____|");

Console.Write("\n\nWhat is the name of your character? ");
string Player = Console.ReadLine();
const string Land = "Ardia";
Console.WriteLine($"\nWelcome to {Land}, {Player}!\n What is your Character's class? (Warrior, Mage, Rogue)");
string PlayerClass = Console.ReadLine();
Console.WriteLine($"\nYou have chosen the {PlayerClass} class.\n What is your defense stat? (1-10)");
int PlayerDefense = int.Parse(Console.ReadLine());
Console.WriteLine($"\nYou have chosen a defense stat of {PlayerDefense}.\n What is your strength stat? (1-10)");
int PlayerStrength = int.Parse(Console.ReadLine());
int PlayerMaxHealth = PlayerStrength * PlayerDefense * 2;
int PlayerHealth = PlayerMaxHealth;
double PlayerHealthPercentage = (double)PlayerHealth / PlayerMaxHealth * 100;
int PlayerMana = 30;
double  PlayerExp = 0;
decimal PlayerGold = 0;
int PlayerLevel = (int)(PlayerExp / 1000) + 1;
int ExperienceToNextLevel = 1000 - (int)(PlayerExp % 1000);
int WeaponDamage = 5;
int PlayerAttackDamage = PlayerStrength + WeaponDamage;
int PlayerSpecialAttackDmg = PlayerAttackDamage * 2;
bool PlayerIsAlive = PlayerHealth > 0;
bool PlayerIsDead = !PlayerIsAlive;
bool PlayerHasFullHealth = PlayerHealth == PlayerMaxHealth;

Console.WriteLine ("+--------------------------------+");
Console.WriteLine("| \t ARDIA");
Console.WriteLine ("+--------------------------------+");
Console.WriteLine($"| Player Name: {Player} ");
Console.WriteLine($"| Land: {Land} ");
Console.WriteLine($"| Class: {PlayerClass} ");
Console.WriteLine($"| Gold: {PlayerGold} ");
Console.WriteLine($"| Experience: {PlayerExp} ");
Console.WriteLine($"| Level: {PlayerLevel} ");
Console.WriteLine ("+--------------------------------+");
Console.WriteLine($"| Health: {PlayerHealth} / {PlayerMaxHealth} ({PlayerHealthPercentage:F2}%)");
Console.WriteLine($"| Strength: {PlayerStrength} ");
Console.WriteLine($"| Defense: {PlayerDefense} ");
Console.WriteLine($"| Mana: {PlayerMana} ");
Console.WriteLine($"| Attack Damage: {PlayerAttackDamage} ");
Console.WriteLine($"| Special Attack Damage: {PlayerSpecialAttackDmg} ");
Console.WriteLine ("+--------------------------------+");

Console.Write("\n\nObecny stan bohatera: ");
if (PlayerHealthPercentage == 100)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("Bohater jest w pełni zdrowy!");
    Console.ResetColor();
}
else if (PlayerHealthPercentage > 70)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Bohater jest prawie zdrowy.");
    Console.ResetColor();
}
else if (PlayerHealthPercentage > 30)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Bohater potrzebuje leczenia.");
    Console.ResetColor();
}
else if (PlayerHealthPercentage > 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Bohater jest w stanie krytycznym.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Bohater nie żyje.");
    Console.ResetColor();
}

bool maLvl10 = PlayerLevel >= 10;
bool maLvl5 = PlayerLevel >= 5;
