using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fighting_system
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int enemyHP = 500;
            int hp = 200;

        fight:
            Random rnd = new Random();
            int doboKocka = rnd.Next(1, 12);
            int ellendoboKocka = rnd.Next(1, 12);

            Console.WriteLine(@"                                       Bull man abomination");
        Console.WriteLine($"                                                                  HP: {enemyHP}");
        Console.WriteLine(@"         ,     .
                                        /(     )\               A
                                   .--.( `.___.' ).--.         /_\
                                   `._ `%_&%#%$_ ' _.'     /| <___> |\
                                      `|(@\*%%/@)|'       / (  |L|  ) \
                                       |  |%%#|  |       J d8bo|=|od8b L
                                        \ \$#%/ /        | 8888|=|8888 |
                                        |\|%%#|/|        J Y8P""|=|""Y8P F
                                        | (."".)%|        \ (  |L|  ) /
                                    ___.'  `-'  `.___      \|  |L|  |/
                                  .'#*#`-       -'$#*`.       / )|
                                 /#%^#%*_ *%^%_  #  %$%\    .J (__)
                                 #&  . %%%#% ###%*.   *%\.-'&# (__)
                                 %*  J %.%#_|_#$.\J* \ %'#%*^  (__)
                                 *#% J %$%%#|#$#$ J\%   *   .--|(_)
                                 |%  J\ `%%#|#%%' / `.   _.'   |L|
                                 |#$%||` %%%$### '|   `-'      |L|
                                 (#%%||` #$#$%%% '|            |L|
                                 | ##||  $%%.%$%  |            |L|
                                 |$%^||   $%#$%   |  VK/cf     |L|
                                 |&^ ||  #%#$%#%  |            |L|
                                 |#$*|| #$%$$#%%$ |\           |L|
                                 ||||||  %%(@)$#  |\\          |L|
                                 `|||||  #$$|%#%  | L|         |L|
                                      |  #$%|$%%  | ||l        |L|
                                      |  ##$H$%%  | |\\        |L|
                                      |  #%%H%##  | |\\|       |L|
                                      |  ##% $%#  | Y|||       |L|
                                      J $$#* *%#% L  |E/
                                      (__ $F J$ __)  F/
                                      J#%$ | |%%#%L
                                      |$$%#& & %%#|
                                      J##$ J % %%$F
                                       %$# * * %#&
                                       %#$ | |%#$%
                                       *#$%| | #$*
                                      /$#' ) ( `%%\
                                     /#$# /   \ %$%\
                                    ooooO'     Ooooo");
            Console.WriteLine($"Your health: {hp}");
            Console.WriteLine(" Press E to attack");
            if (enemyHP <= 0)
            {
                Console.Clear();
                Console.WriteLine("You have defeated the enemy!, press anything to leave");
            }
            if (hp <= 0)
            {
                Console.Clear();
                Console.WriteLine("Game over loser, press anything to leave");
            }
            do
            {
                var cki = Console.ReadKey(true);
                if (cki.Key.ToString() == "E")
                {
                    Console.Clear();
                    if (doboKocka == 12)
                    {
                        enemyHP = enemyHP - 300;
                        Console.WriteLine($"You have dealt 300 damage to the enemy!");
                    }
                    else if (doboKocka == 11)
                    {
                        enemyHP = enemyHP - 250;
                        Console.WriteLine($"You have dealt 250 damage to the enemy!");
                    }

                    else if (doboKocka == 10)
                    {
                        enemyHP = enemyHP - 225;
                        Console.WriteLine($"You have dealt 225 damage to the enemy!");
                    }
                    else if (doboKocka == 9)
                    {
                        enemyHP = enemyHP - 200;
                        Console.WriteLine($"You have dealt 200 damage to the enemy!");
                    }
                    else if (doboKocka == 8)
                    {
                        enemyHP = enemyHP - 190;
                        Console.WriteLine($"You have dealt 190 damage to the enemy!");
                    }
                    else if (doboKocka == 7)
                    {
                        enemyHP = enemyHP - 150;
                        Console.WriteLine($"You have dealt 150 damage to the enemy!");
                    }
                    else if (doboKocka == 6)
                    {
                        enemyHP = enemyHP - 125;
                        Console.WriteLine($"You have dealt 125 damage to the enemy!");
                    }
                    else if (doboKocka == 5)
                    {
                        enemyHP = enemyHP - 100;
                        Console.WriteLine($"You have dealt 100 damage to the enemy!");
                    }
                    else if (doboKocka == 4)
                    {
                        enemyHP = enemyHP - 70;
                        Console.WriteLine($"You have dealt 70 damage to the enemy!");
                    }
                    else if (doboKocka == 3)
                    {
                        enemyHP = enemyHP - 60;
                        Console.WriteLine($"You have dealt 60 damage to the enemy!");
                    }
                    else if (doboKocka == 2)
                    {
                        enemyHP = enemyHP - 50;
                        Console.WriteLine($"You have dealt 50 damage to the enemy!");
                    }
                    else if (doboKocka == 1)
                    {
                        enemyHP = enemyHP - 40;
                        Console.WriteLine($"You have dealt 40 damage to the enemy!");
                    }
                    if (ellendoboKocka == 12)
                    {
                        hp = hp - 200;
                    }
                    else if (ellendoboKocka == 11)
                    {
                        hp = hp - 190;
                        Console.WriteLine($"The enemy have dealt 190 damage against you");
                    }

                    else if (ellendoboKocka == 10)
                    {
                        hp = hp - 170;
                        Console.WriteLine($"The enemy have dealt 200 damage against you");
                    }
                    else if (ellendoboKocka == 9)
                    {
                        hp = hp - 150;
                        Console.WriteLine($"The enemy have dealt 150 damage against you");
                    }
                    else if (ellendoboKocka == 8)
                    {
                        hp = hp - 120;
                        Console.WriteLine($"The enemy have dealt 120 damage against you");
                    }
                    else if (ellendoboKocka == 7)
                    {
                        hp = hp - 100;
                        Console.WriteLine($"The enemy have dealt 100 damage against you");
                    }
                    else if (ellendoboKocka == 6)
                    {
                        hp = hp - 60;
                        Console.WriteLine($"The enemy have dealt 60 damage against you");
                    }
                    else if (ellendoboKocka == 5)
                    {
                        hp = hp - 40;
                        Console.WriteLine($"The enemy have dealt 40 damage against you");
                    }
                    else if (ellendoboKocka == 4)
                    {
                        hp = hp - 30;
                        Console.WriteLine($"The enemy have dealt 30 damage against you");
                    }
                    else if (ellendoboKocka == 3)
                    {
                        hp = hp - 20;
                        Console.WriteLine($"The enemy have dealt 20 damage against you");
                    }
                    else if (ellendoboKocka == 2)
                    {
                        hp = hp - 10;
                        Console.WriteLine($"The enemy have dealt 10 damage against you");
                    }
                    else if (ellendoboKocka == 1)
                    {
                        hp = hp - 5;
                        Console.WriteLine($"The enemy have dealt 5 damage against you");
                    }
                    goto fight;
                }
            } while (enemyHP > 0 && hp > 0);

        }
    }
}
