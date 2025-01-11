using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midterm_FR.classes;

namespace Midterm_FR
{
    class Program
    {
        static bool gameOver = false;

        static void Main(string[] args)
        {
            ConsoleKeyInfo input;

            Console.WriteLine("---- POKEMON GAME ----");
            do
            {
                Console.WriteLine();
                Console.WriteLine("Menu of Commands: L = Look arround | A = Attack | S = Statistics | E = Energies | P = Pokemons Collection | Q = Quit");

                input = Console.ReadKey();
                Console.WriteLine();
                
                if (input.Key == ConsoleKey.L)
                {
                    if (Player.Enemy == null)
                    {
                        Console.WriteLine("You start exploring !");
                        Explore();
                    }
                    else
                    {
                        Console.WriteLine("Your enemy is attacking you !");
                        //The enemy of player is attacking player's current pokemon
                        Player.Enemy.Attack(Player.CurrentPokemon);
                        Console.WriteLine(Player.CurrentPokemon.ToString());
                    }
                }
                if (input.Key == ConsoleKey.A)
                {
                    if (Player.Enemy == null)
                    {
                        Console.WriteLine("There is no enemy to attack !");
                    }
                    else
                    {
                        Console.WriteLine("You start the Battle !");
                        Battle();
                    }
                }
                if (input.Key == ConsoleKey.S)
                {
                    if (Player.CurrentPokemon != null)
                    {
                        Console.WriteLine("Pokemon Statistics: " + Player.CurrentPokemon.ToString());
                    }
                    else
                    {
                        Console.WriteLine("You did not pick any pokemon yet !!");
                    }

                }
                if (input.Key == ConsoleKey.E)
                {
                    if (Player.EnergiesCollection.Count > 0)
                    {
                        Player.ActivateAllPokemons();
                        Player.DisplayEnergies();
                    }
                    else
                    {
                        Console.WriteLine("You did not collect any energy yet !!");
                    }
                }
                if (input.Key == ConsoleKey.P)
                {
                    Player.DisplayPokemons();
                }
                
            } while (input.Key != ConsoleKey.Q && !gameOver);

            Console.WriteLine("Press any key to quit the game ...");
            Console.ReadKey();
        }
        //-----------------------------------------------------------------------------------------
        
        public static void Battle()
        {
            if (Player.Enemy != null && Player.CurrentPokemon != null &&
               !Player.CurrentPokemon.IsKnockout() && !Player.Enemy.IsKnockout())
            {
                if (Player.CurrentPokemon.Speed > Player.Enemy.Speed)
                {
                    Console.WriteLine("Your pokemon is attacking ...");
                    Player.CurrentPokemon.Attack(Player.Enemy);
                    Console.WriteLine(Player.Enemy.ToString());
                    Console.WriteLine("Your enemy is attacking ...");
                    Player.Enemy.Attack(Player.CurrentPokemon);
                    Console.WriteLine(Player.CurrentPokemon.ToString());
                }
                else
                {
                    Console.WriteLine("Your enemy is attacking ...");
                    Player.Enemy.Attack(Player.CurrentPokemon);
                    Console.WriteLine(Player.CurrentPokemon.ToString());
                    Console.WriteLine("Your pokemon is attacking ...");
                    Player.CurrentPokemon.Attack(Player.Enemy);
                    Console.WriteLine(Player.Enemy.ToString());
                }

            }

            if (Player.Enemy != null && Player.Enemy.IsKnockout())
            {
                Console.WriteLine("You've caught " + Player.Enemy.Name + "(^_^)");

                Player.Enemy.Heal();
                Player.AddPokemon(Player.Enemy);
                Player.CurrentPokemon.Heal();

                Player.CurrentPokemon = null;
                Player.Enemy = null;
            }
            else
            if (Player.CurrentPokemon != null && Player.CurrentPokemon.IsKnockout())
            {
                Console.WriteLine("Your pokemon is knockout (-_-)zzz ");
                Player.CurrentPokemon = null;
                Player.Enemy = null;
            }
            else
            if (Player.CurrentPokemon == null)
            {
                Console.WriteLine("You don't have any ACTIVE Pokemon :(");
                Console.WriteLine("--- GAME OVER ---");
                gameOver = true;
            }
        }
        //----------------------------------------------------------------------
        public static void Explore()
        {
            RNG randomGenerator = RNG.GetInstance();
            int random = randomGenerator.Next(0, 17);
            switch (random)
            {
                case 0:
                    Console.WriteLine("The Grass Monster Bulbasaur approaches (+_+) Prepare for battle !");
                    Pokemon grassPokemon1 = new Pokemon("Bulbasaur", 38, 100, 50, Energy.Grass);
                    grassPokemon1.CurrentState = State.Active;
                    Player.Enemy = grassPokemon1;
                    Player.ActivateAllPokemons();
                    Player.CurrentPokemon = Player.PickPokemon();
                    break;
                case 1:
                    Console.WriteLine("The Grass Monster Treecko approaches (+_+) Prepare for battle !");
                    Pokemon grassPokemon2 = new Pokemon("Treecko", 38, 100, 50, Energy.Grass);
                    grassPokemon2.CurrentState = State.Active;
                    Player.Enemy = grassPokemon2;
                    Player.ActivateAllPokemons();
                    Player.CurrentPokemon = Player.PickPokemon();
                    break;

                case 2:
                    Console.WriteLine("The Fire Monster Charmander approaches (>_<) Prepare for battle !");
                    Pokemon firePokemon1 = new Pokemon("Charmander", 45, 100, 65, Energy.Fire);
                    firePokemon1.CurrentState = State.Active;
                    Player.Enemy = firePokemon1;
                    Player.ActivateAllPokemons();
                    Player.CurrentPokemon = Player.PickPokemon();
                    break;
                case 3:
                    Console.WriteLine("The Fire Monster Cyndaquil approaches (>_<) Prepare for battle !");
                    Pokemon firePokemon2 = new Pokemon("Cyndaquil", 40, 100, 70, Energy.Fire);
                    firePokemon2.CurrentState = State.Active;
                    Player.Enemy = firePokemon2;
                    Player.ActivateAllPokemons();
                    Player.CurrentPokemon = Player.PickPokemon();
                    break;
                case 4:
                    Console.WriteLine("The Water Monster Squirtle approaches (._.) Prepare for battle !");
                    Pokemon waterPokemon1 = new Pokemon("Squirtle", 48, 100, 56, Energy.Water);
                    waterPokemon1.CurrentState = State.Active;
                    Player.Enemy = waterPokemon1;
                    Player.ActivateAllPokemons();
                    Player.CurrentPokemon = Player.PickPokemon();
                    break;
                case 5:
                    Console.WriteLine("The Water Monster Seel approaches (._.) Prepare for battle !");
                    Pokemon waterPokemon2 = new Pokemon("Seel", 30, 100, 35, Energy.Water);
                    waterPokemon2.CurrentState = State.Active;
                    Player.Enemy = waterPokemon2;
                    Player.ActivateAllPokemons();
                    Player.CurrentPokemon = Player.PickPokemon();
                    break;
                case 6:
                case 7:
                    Console.WriteLine("You found Fire Energy (^_^)");
                    Player.AddEnergy(Energy.Fire);
                    break;
                case 8:
                case 9:
                    Console.WriteLine("You found Grass Energy (^_^)");
                    Player.AddEnergy(Energy.Grass);
                    break;
                case 10:
                case 11:
                    Console.WriteLine("You found Water Energy (^_^)");
                    Player.AddEnergy(Energy.Water);
                    break;
                case 12:
                case 13:
                    Console.WriteLine("You found Lightning Energy (^_^)");
                    Player.AddEnergy(Energy.Lightning);
                    break;
                default:
                    Console.WriteLine("You are looking around (*_*)");
                    break;
            }
        }
        
    }
}
