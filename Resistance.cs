namescape Pokebattle
{
    public class Resistance
    {
        public Resistance(string typeResist, int resistance)
        {
            TypeResist = typeResist;
            Resistant = resistance;
        }
        public string TypeResist { get; private set; }
        public int Resistant { get; set; }
    }
}