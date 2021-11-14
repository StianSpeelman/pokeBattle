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
            var pokemon = new Giratina();
            var hostilePokemon = new Arceus();

            Console.WriteLine("Press enter to start the battle");
            Console.ReadLine();
            hostilePokemon.Damage(pokemon, 0);
            pokemon.Damage(pokemonHostile, 1);

            Console.WriteLine($"{pokemon.retrieveLivingPKMN()}");
            Console.WriteLine($"Giratina used {pokemon.retAttacks()[0].Name} on {hostilePokemon.Name}, {hostilePokemon.Name}'s health has been lowered to {hostilePokemon.Health}");
            Console.WriteLine($"Arceus used {hostilePokemon.retAttacks()[1].Name} on {pokemon.Name}, {pokemon.Name}'s health has been lowered to {pokemon.Health}");
            Console.WriteLine("currently living Pokemon are:");
            Console.WriteLine($"{pokemon.retrieveLivingPKMN}");

            hostilePokemon.Damage(pokemon, 1);
            pokemon.Damage(hostilePokemon, 0);

            Console.WriteLine($"{pokemon.retrieveLivingPKMN()}");
            Console.WriteLine($"Giratina used {pokemon.retAttacks()[0].Name} on {hostilePokemon.Name}, {hostilePokemon.Name}'s health has been lowered to {hostilePokemon.Health}");
            Console.WriteLine($"Arceus used {hostilePokemon.retAttacks()[1].Name} on {pokemon.Name}, {pokemon.Name}'s health has been lowered to {pokemon.Health}");
            Console.WriteLine("currently living Pokemon are:");
            Console.WriteLine($"{pokemon.retrieveLivingPKMN}");

            Console.ReadKey();
        }
    }
}