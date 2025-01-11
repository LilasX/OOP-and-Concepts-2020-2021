using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_FR.classes
{
    public static class Player
    {
        public static List<Pokemon> PokemonsCollection = new List<Pokemon>();
        public static List<Energy>  EnergiesCollection = new List<Energy>();
        public static Pokemon Enemy = null;
        public static Pokemon CurrentPokemon = null; 

        static Player()
        {
           // Pokemon firstPokemon = new Pokemon("Pikachu", 40, 100, 55, Energy.Lightning);
           // firstPokemon.CurrentState = State.Active;
           // PokemonsCollection.Add(firstPokemon);
        }
        //---------------------------------------------------------------------------------
        public static void AddPokemon(Pokemon pokemon)
        {
           
        }
        //---------------------------------------------------------------------------------
        public static void AddEnergy(Energy energy)
        {
            
           
        }
        //---------------------------------------------------------------------------------
        public static Pokemon PickPokemon()
        {
            Pokemon selectedObj = null;
            //--- TODO
            return selectedObj;
        }
        //---------------------------------------------------------------------------------
        public static void ActivateAllPokemons()
        {
            
        }
        /*
        //----------------------------------------------------------------------------------
        public static void DisplayPokemons()
        {
            Console.Write("Pokemons Collection: ");
            foreach (Pokemon p in PokemonsCollection)
            {
                Console.Write(p.Name + " : "+ p.CurrentState+" | ");
            }
        }
        //----------------------------------------------------------------------------------
        public static void DisplayEnergies()
        {
            Console.Write("Energies Collection: ");
            foreach (Energy energy in EnergiesCollection)
            {
                Console.Write(energy + " | ");
            }
        }
        */
    }
}
