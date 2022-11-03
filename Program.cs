const string PIRATE = "Pirate"; 
const string STONECHEWER = "Stone Chewer";
const string GHOSTWARRIOR = "Ghost Warrior";
const string OUTWORLDER = "Outworlder";
const string MONSTERKNIGHT = "Monster Knight";
const string DARKGOBLIN = "Dark Goblin";

const int PIRATESPEED = 3;
const int PIRATEATTACK = 3;
const int PIRATEHEALTH = 20;
const int PIRATEARMOR = 3;
const int STONECHEWERSPEED = 1;
const int STONECHEWERATTACK = 8;
const int STONECHEWERHEALTH = 50;
const int STONECHEWERARMOR = 10;
const int GHOSTWARRIORSPEED = 5;
const int GHOSTWARRIORATTACK = 2;
const int GHOSTWARRIORHEALTH = 20;
const int GHOSTWARRIORARMOR = 2;
const int OUTWORLDERSPEED = 10;
const int OUTWORLDERATTACK = 1;
const int OUTWORLDERHEALTH = 15;
const int OUTWORLDERARMOR = 2;
const int MONSTERKNIGHTSPEED = 3;
const int MONSTERKNIGHTATTACK = 4;
const int MONSTERKNIGHTHEALTH = 15;
const int MONSTERKNIGHTARMOR = 3;
const int DARKGOBLINSPEED = 3;
const int DARKGOBLINATTACK = 1;
const int DARKGOBLINHEALTH = 10;
const int DARKGOBLINARMOR = 8; 

double player1Attack = 0;
double player1Health = 0;
double player1Speed = 0;
double player1Armor = 0;
double player2Attack = 0;
double player2Health = 0;
double player2Speed = 0;
double player2Armor = 0;

System.Console.WriteLine();
System.Console.Write("Player 1, choose your character (Pirate, Stone Chewer, Ghost Warrior, Outworlder, Monster Knight or Dark Goblin): ");
string player1 = Console.ReadLine()!;
System.Console.Write("Player 2, choose your character (Pirate, Stone Chewer, Ghost Warrior, Outworlder, Monster Knight or Dark Goblin): ");
string player2 = Console.ReadLine()!;
System.Console.WriteLine();

switch(player1)
{
    case PIRATE:
    player1Health = PIRATEHEALTH;
    player1Attack = PIRATEATTACK;
    player1Armor = PIRATEARMOR;
    player1Speed = PIRATESPEED;
    break;

    case STONECHEWER:
    player1Health = STONECHEWERHEALTH;
    player1Attack = STONECHEWERATTACK;
    player1Armor = STONECHEWERARMOR;
    player1Speed = STONECHEWERSPEED;
    break;

    case GHOSTWARRIOR:
    player1Health = GHOSTWARRIORHEALTH;
    player1Attack = GHOSTWARRIORATTACK;
    player1Armor = GHOSTWARRIORARMOR;
    player1Speed = GHOSTWARRIORSPEED;
    break;

    case OUTWORLDER:
    player1Health = OUTWORLDERHEALTH;
    player1Attack = OUTWORLDERATTACK;
    player1Armor = OUTWORLDERARMOR;
    player1Speed = OUTWORLDERSPEED;
    break;

    case MONSTERKNIGHT:
    player1Health = MONSTERKNIGHTHEALTH;
    player1Attack = MONSTERKNIGHTATTACK;
    player1Armor = MONSTERKNIGHTARMOR;
    player1Speed = MONSTERKNIGHTSPEED;
    break;

    case DARKGOBLIN:
    player1Health = DARKGOBLINHEALTH;
    player1Attack = DARKGOBLINATTACK;
    player1Armor = DARKGOBLINARMOR;
    player1Speed = DARKGOBLINSPEED;
    break;

    default:
    System.Console.WriteLine("Invalid input!!!");
    return;
}

switch(player2)
{
    case PIRATE:
    player2Health = PIRATEHEALTH;
    player2Attack = PIRATEATTACK;
    player2Armor = PIRATEARMOR;
    player2Speed = PIRATESPEED;
    break;

    case STONECHEWER:
    player2Health = STONECHEWERHEALTH;
    player2Attack = STONECHEWERATTACK;
    player2Armor = STONECHEWERARMOR;
    player2Speed = STONECHEWERSPEED;
    break;

    case GHOSTWARRIOR:
    player2Health = GHOSTWARRIORHEALTH;
    player2Attack = GHOSTWARRIORATTACK;
    player2Armor = GHOSTWARRIORARMOR;
    player2Speed = GHOSTWARRIORSPEED;
    break;
    
    case OUTWORLDER:
    player2Health = OUTWORLDERHEALTH;
    player2Attack = OUTWORLDERATTACK;
    player2Armor = OUTWORLDERARMOR;
    player2Speed = OUTWORLDERSPEED;
    break;

    case MONSTERKNIGHT:
    player2Health = MONSTERKNIGHTHEALTH;
    player2Attack = MONSTERKNIGHTATTACK;
    player2Armor = MONSTERKNIGHTARMOR;
    player2Speed = MONSTERKNIGHTSPEED;
    break;

    case DARKGOBLIN:
    player2Health = DARKGOBLINHEALTH;
    player2Attack = DARKGOBLINATTACK;
    player2Armor = DARKGOBLINARMOR;
    player2Speed = DARKGOBLINSPEED;
    break;

    default:
    System.Console.WriteLine("Invalid input!!!");
    return;
}

player1Health += player1Armor;
player2Health += player2Armor;

double fight1 = player1Attack * player1Speed;
double fight2 = player2Attack * player2Speed;

while(player1Health > 0 && player2Health > 0)
{
    player1Health -= fight2;
    player2Health -= fight1;
}

if(player1Health > 0)
{
    System.Console.WriteLine($"{player1} (player 1) won the Battle");
}

if(player2Health > 0)
{
    System.Console.WriteLine($"{player2} (player 2) won the battle");
}

if(player1Health <= 0 && player2Health <= 0 )
{
    System.Console.WriteLine("The battle ended in a draw");
}