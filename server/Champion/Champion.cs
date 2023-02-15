namespace server.Champion
{
    public class Champion : IChampion
    {
        #region VARIABLES

        private string _name;
        private double _health;
        private double _healthRegen;
        private double _ressource;
        private double _ressourceRegen;
        private double _magicResist;
        private double _armor;
        private float _critDamage;
        private int _moveSpeed;

        #endregion

        #region GETTER SETTER

        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public double Health {
            get { return _health; }
            set { _health = value; }
        }

        public double HealthRegen // per 5s
        {
            get { return _healthRegen; }
            set { _healthRegen = value; }
        }

        public double Ressource
        {
            get { return _ressource; }
            set { _ressource = value; }
        }

        public double RessourceRegen // per 5s
        {
            get { return _ressourceRegen; }
            set { _ressourceRegen = value; }
        }

        public double Armor
        {
            get { return _armor; }
            set { _armor = value; }
        }

        public double MagicResist
        {
            get { return _magicResist; }
            set { _magicResist = value; }
        }

        public float CritDamage
        {
            get { return _critDamage; }
            set { _critDamage = value; }
        }

        public int MoveSpeed
        {
            get { return _moveSpeed; }
            set { _moveSpeed = value; }
        }

        #endregion


        public Champion(string name) // string Ttest
        {
            _name = name;
        }

        #region METHODS
        #endregion
    }
}
