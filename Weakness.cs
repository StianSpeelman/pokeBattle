namespace pokeBattle
{
    public class Weakness
    {
        public Weakness(string weakType, float multiply)
        {
            weaknessDamage = weakType;
            Multiplier = multiply;
        }
        // weaknessDamage wordt vergeleken in de Pokemon.cs waar weakness wordt vergeleken met Energytype
        public string weaknessDamage { get; private set; }
        public float Multiplier { get; set; }
    }
}