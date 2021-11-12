using System.Collections.Generic;

namespace pokeBattle
{
    public class Pokemon
    {
        public string Name { get; private set; }
        public Energytype Type { get; private set; }
        private int HP { get; set; }
        private int Health { get; set; }
        protected List<Attack> Attacks { get; set; }
        protected Resistance Resistances { get; set; }
        protected Weakness weaknesses { get; set; }

        protected static int livingPokemon = 0;

        public Pokemon(string name, int hitpoints, Energytype energytype, Resistance resistance, Weakness weaknesses)
        {
            Name = name;
            HitPoints = hitpoints;
            Health = hitpoints;
            Type = energytype;
            Attacks = new List<Attack>();
            Resistances = resistance;
            Weakness = weaknesses;
            livingPokemon++;
        }

        public void Damage(Pokemon dealer, int attack)
        {
            if (Type.TypeWeak == dealer.Type.Type)
            {
                Health -= (int)(dealer.Attacks[attack].Damage * weaknesses.Multiplier);
            } else if(Type.TypeResist == dealer.Type.Type)
            {
                Health -= (dealer.Attacks[attack].Damage - Resistances.Resisting);
            }
            else
            {
                Health -= (dealer.Attacks[attack].Damage);
            }
            if (Health <= 0)
            {
                livingPokemon--;
            }
        }

        public List<Attack> retAttacks()
        {
            return Attacks;
        }

        public static int retrieveLivingPKMN()
        {
            return livingPokemon;
        }
    }

    public class Giratina : Pokemon
    {
        public Giratina():base("Giratina", 504, new Energytype("dragon", "grass", "ice"), new Resistance("dragon", "grass", "ice").TypeResist, 20), new Weakness(new Energytype("dragon", "grass", "ice").TypeWeak, 1.5F))
        {
            Attacks.Add(new Attack("Shadow Force", 120));
            Attacks.Add(new Attack("Giga Impact", 150));
        }
    }

    public class Arceus : Pokemon
    {
        public Arceus():base("Arceus", 444, new Energytype("ice", "ghost", "steel"), new Resistance("ice", "ghost", "steel").TypeResist, 20), new Weakness(new Energytype("ice", "ghost", "steel").TypeWeak, 2.0F))
        {
            Attacks.Add(new Attack("Judgment", 100));
            Attacks.Add(new Attack("Hyper Beam", 150));
        }
    }
}