using System;

public class Program
{
    public static void Main(string[] args)
    {
        Player player1 = new Player("Knight1", 200, 5, 1, 4, 2, 2);
        Player player2 = new Player("Knight2", 200, 5, 1, 4, 2, 2);
        Player player3 = new Player("Knight3", 200, 5, 1, 4, 2, 2);
        Enemy enemy1 = new Enemy("Goblin", 125, 3, 2, 1, 3, 4);
        Enemy enemy2 = new Enemy("Gooblin", 125, 3, 2, 1, 3, 4);
        Enemy enemy3 = new Enemy("Goooblin", 125, 3, 2, 1, 3, 4);
        player1.DisplayStats();
        player2.DisplayStats();
        player3.DisplayStats();
        enemy1.DisplayStats();
        enemy2.DisplayStats();
        enemy3.DisplayStats();
     // player1.atkP(enemy1);
        player1.DisplayStats();
        enemy1.DisplayStats(); 
        Player[] arrayPlayer = {player1, player2, player3};
        Enemy[] arrayEnemy = {enemy1, enemy2, enemy3};
        int n = 0;
      //while(enemyPartyStatus == alive && allyPartyStatus == alive)
    //  {
            Console.WriteLine("Please choose an action. " + arrayPlayer[n].GetName() + ".");
            Console.WriteLine("1.Attack");
            Console.WriteLine("2.Magic Attack");
            string input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    Console.WriteLine("Choose an enemy to attack.");
                    Console.WriteLine("1." + enemy1.GetName());
                    Console.WriteLine("2." + enemy2.GetName());
                    Console.WriteLine("3." + enemy3.GetName());
                    string target = Console.ReadLine();
                    if(target == "1")
                    {
                        arrayPlayer[n].atkP(enemy1);
                    }
                    else if(target == "2")
                    {
                        arrayPlayer[n].atkP(enemy2);
                    }
                    else if(target == "3")
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
                    if(target2 == "1")
                    {
                        arrayPlayer[n].atkM(enemy1);
                    }
                    else if(target2 == "2")
                    {
                        arrayPlayer[n].atkM(enemy2);
                    }
                    else if(target2 == "3")
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
}