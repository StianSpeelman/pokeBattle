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
    }
}