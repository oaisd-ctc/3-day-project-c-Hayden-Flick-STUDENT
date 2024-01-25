using System;

public class Program
{
    public static void Main(string[] args)
    {
        Player player1 = new Player("Knight", 175, 4, 2, 5, 3, 2);
        Player player2 = new Player("Rogue", 125, 3, 3, 2, 3, 5);
        Player player3 = new Player("Mage", 100, 1, 5, 1, 5, 2);
        Enemy enemy1 = new Enemy("Goblin", 75, 3, 1, 1, 1, 5);
        Enemy enemy2 = new Enemy("Orc", 125, 4, 3, 4, 2, 3);
        Enemy enemy3 = new Enemy("Demon", 200, 4, 5, 5, 4, 1);
        // player1.DisplayStats();
        // player2.DisplayStats();
        // player3.DisplayStats();
        // enemy1.DisplayStats();
        // enemy2.DisplayStats();
        // enemy3.DisplayStats();
        // // player1.atkP(enemy1);
        // player1.DisplayStats();
        // enemy1.DisplayStats();
        DisplayField(player1, player2, player3, enemy1, enemy2, enemy3);
        Player[] arrayPlayer = { player1, player2, player3 };
        Enemy[] arrayEnemy = { enemy1, enemy2, enemy3 };
        int n = 0;
        //while(enemyPartyStatus == alive && allyPartyStatus == alive)
        //  {
        Console.WriteLine("Please choose an action. " + arrayPlayer[n].GetName() + ".");
        Console.WriteLine("1.Attack");
        Console.WriteLine("2.Magic Attack");
        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                Console.WriteLine("Choose an enemy to attack.");
                Console.WriteLine("1." + enemy1.GetName());
                Console.WriteLine("2." + enemy2.GetName());
                Console.WriteLine("3." + enemy3.GetName());
                string target = Console.ReadLine();
                if (target == "1")
                {
                    arrayPlayer[n].atkP(enemy1);
                }
                else if (target == "2")
                {
                    arrayPlayer[n].atkP(enemy2);
                }
                else if (target == "3")
                {
                    arrayPlayer[n].atkP(enemy3);
                }
                else
                {
                    Console.WriteLine("Please enter a valid target");
                }
                break;
            case "2":
                Console.WriteLine("Please choose an enemy to attack.");
                {
                    Console.WriteLine("1." + enemy1.GetName());
                    Console.WriteLine("2." + enemy2.GetName());
                    Console.WriteLine("3." + enemy3.GetName());
                    string target2 = Console.ReadLine();
                    if (target2 == "1")
                    {
                        arrayPlayer[n].atkM(enemy1);
                    }
                    else if (target2 == "2")
                    {
                        arrayPlayer[n].atkM(enemy2);
                    }
                    else if (target2 == "3")
                    {
                        arrayPlayer[n].atkM(enemy3);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid target");
                    }
                    break;
                }
            default:
                break;
        }
        enemy1.DisplayStats();
        //   }


    }

    public static void DisplayField(Player player1, Player player2, Player player3, Enemy enemy1, Enemy enemy2, Enemy enemy3)
    {
        System.Console.WriteLine("==============================");
        player1.DisplayStats();
        player2.DisplayStats();
        player3.DisplayStats();
        System.Console.WriteLine("---------------");
        enemy1.DisplayStats();
        enemy2.DisplayStats();
        enemy3.DisplayStats();
        System.Console.WriteLine("==============================");
    }
}