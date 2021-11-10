namespace pokeBattle
{
    public class Attack
    {
        public Attack(string name, int damage)
        {
            Move = name;
            Damage = damage;
        }
        public string Move { get; set; }
        public int Damage { get; set; }
    }
}