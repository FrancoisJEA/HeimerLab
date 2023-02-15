namespace server.Champion
{
    public interface IChampion
    {
        public string Name  // property
        { get; set; }

        // Base Stats
        public double Health { get; set; }

        public double HealthRegen // per 5s
        { get; set; }

        public double Ressource { get; set; }

        public double RessourceRegen { get; set; }

        public double Armor { get; set; }

        public double MagicResist { get; set; }

        public float CritDamage{ get; set; }

        public int MoveSpeed { get; set; }

    }
}
