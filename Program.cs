using System;

public class Program
{
    public static Player player1 = new Player("Knight", 175, 4, 2, 5, 3, 2);
    public static Player player2 = new Player("Rogue", 125, 3, 3, 2, 3, 5);
    public static Player player3 = new Player("Mage", 100, 1, 5, 1, 5, 2);
    public static Enemy enemy1 = new Enemy("Goblin", 75, 3, 1, 1, 2, 4);
    public static Enemy enemy2 = new Enemy("Orc", 125, 4, 3, 4, 2, 3);
    public static Enemy enemy3 = new Enemy("Demon", 200, 4, 5, 5, 4, 1);
    public static Player[] arrayPlayer = { player1, player2, player3 };
    public static Enemy[] arrayEnemy = { enemy1, enemy2, enemy3 };
    public static void Main(string[] args)
    {
        Player[] arrayPlayer = { player1, player2, player3 };
        Enemy[] arrayEnemy = { enemy1, enemy2, enemy3 };
        while(!CheckIfBattleIsOver())
        {
            PlayersTurn();
            EnemysTurn();
        }


        enemy1.DisplayStats();
        enemy2.DisplayStats();
        enemy3.DisplayStats();
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
    public static bool CheckIfBattleIsOver()
    {
        int playersDead = 0;
        int enemysDead = 0;
        bool enemyStatus = true;
        bool playerStatus = true;
        foreach(Enemy monster in arrayEnemy)
            {
                if(monster.GetHP() == 0)
                {
                    enemysDead++;
                }
            }
            if(enemysDead == 3)
            {
                Console.WriteLine("Game Over.");
                Console.WriteLine("You WON! TYEAHHHAHEHAH!");
                return true;
            }
            foreach(Player humans in arrayPlayer)
            {
                if(humans.GetHP() == 0)
                {
                    playersDead++;
                }
            }
            if(playersDead == 3)
                {
                    Console.WriteLine("Game Over!");
                    Console.WriteLine("You're bad");
                    return true;
                }
            return false;
    }
    public static void PlayersTurn()
    {
        for(int n = 0; n <= arrayPlayer.Length - 1; n++)
        {
            DisplayField(player1, player2, player3, enemy1, enemy2, enemy3);
            if(!arrayPlayer[n].GetAlive())
            {
                break;
            }
                Console.WriteLine("Please choose an action, " + arrayPlayer[n].GetName() + ".");
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
                        break;
                    }
                    else if (target == "2")
                    {
                        arrayPlayer[n].atkP(enemy2);
                        break;
                    }
                    else if (target == "3")
                    {
                        arrayPlayer[n].atkP(enemy3);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid target");
                        break;
                    }
                    break;
                case "2":
                    Console.WriteLine("Please choose an enemy to attack.");
                
                    Console.WriteLine("1." + enemy1.GetName());
                    Console.WriteLine("2." + enemy2.GetName());
                    Console.WriteLine("3." + enemy3.GetName());
                    string target2 = Console.ReadLine();
                    if (target2 == "1")
                    {
                        arrayPlayer[n].atkM(enemy1);
                        break;
                    }
                    else if (target2 == "2")
                    {
                        arrayPlayer[n].atkM(enemy2);
                        break;
                    }
                    else if (target2 == "3")
                    {
                        arrayPlayer[n].atkM(enemy3);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid target");
                        break;
                    }
                
                    return;
                
                    default:
                    break;
                
                }
            }
        } 
    
    public static void EnemysTurn()
    {
        for(int m = 0; m <= arrayEnemy.Length - 1; m++)
        {

            DisplayField(player1, player2, player3, enemy1, enemy2, enemy3);
           Random rand = new Random();
           int attackType = rand.Next(1, 3);
           int playerAttacked = rand.Next(0, 3);
           if(attackType == 1)
           {
                arrayEnemy[m].atkP(arrayPlayer[playerAttacked]);
           }
           else
           {
                arrayEnemy[m].atkM(arrayPlayer[playerAttacked]);
           }
        }
    }
}
    
   /* public static bool EnemyPartyStatus()
        {
            bool enemysAlive = true;
            if(enemy1.GetHP() == 0 && enemy2.GetHP() == 0 && enemy3.GetHP() == 0)
            {
            return enemysAlive = false; 
            }
            else
            {
            return enemysAlive;
            }
            return enemysAlive;
        */
