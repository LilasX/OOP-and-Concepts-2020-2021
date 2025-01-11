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
        private static List<Pokemon> pokemonsCollection = new List<Pokemon>();
        private static List<Energy> energiesCollection = new List<Energy>();
        private static Pokemon enemy = null;
        private static Pokemon currentPokemon = null;

        public static List<Pokemon> PokemonsCollection { get => pokemonsCollection; set => pokemonsCollection = value; }
        public static List<Energy> EnergiesCollection { get => energiesCollection; set => energiesCollection = value; }
        public static Pokemon Enemy { get => enemy; set => enemy = value; }
        public static Pokemon CurrentPokemon { get => currentPokemon; set => currentPokemon = value; }

        static Player()
        {
            Pokemon firstPokemon = new Pokemon("Pikachu", 40, 100, 55, Energy.Lightning);
            firstPokemon.CurrentState = State.Active;
            PokemonsCollection.Add(firstPokemon);
        }
        //---------------------------------------------------------------------------------
        public static void AddPokemon(Pokemon pokemon)
        {
            PokemonsCollection.Add(pokemon);
        }
        //---------------------------------------------------------------------------------
        public static void AddEnergy(Energy energy)
        {
            foreach(Energy e in EnergiesCollection)
            {
                if (energy != e)
                {
                    EnergiesCollection.Add(energy);
                }
            }
        }
        //---------------------------------------------------------------------------------
        public static Pokemon PickPokemon()
        {
            Pokemon selectedObj = CurrentPokemon;
            //--- TODO
            foreach (Pokemon p in PokemonsCollection)
            {
                selectedObj = p;
                if (p.Speed > selectedObj.Speed)
                {
                    selectedObj = p;
                    
                }
            }
            selectedObj.Heal();
            return selectedObj;
        }
        //---------------------------------------------------------------------------------
        public static void ActivateAllPokemons()
        {
            foreach (Energy e in EnergiesCollection)
            {
                foreach(Pokemon p in PokemonsCollection)
                {
                    if(p.CurrentState == State.Innactive && p.Type == e)
                    {
                        p.Heal();
                        p.CurrentState = State.Active;
                    }
                }
            }
            
        }
        
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
        
    }
}
