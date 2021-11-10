using System
using System.Test.Json;
using System.Collections.Generic;
using System.Linq;

namespace pokeBattle
{
    class program
    {
        static void Main(string[] args)
        {
            var pokemon = new Pikachu();
            var hostilePokemon = new Squirtle();

            Console.WriteLine("Press enter to start the battle");
            Console.ReadLine();
            hostilePokemon.Damage(pokemon, 0);
        }
    }
}