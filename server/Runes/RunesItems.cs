using NHibernate.Mapping;
using System.Xml.Linq;

namespace server.Runes
{
    public class RunesItems
    {
        #region RUNES
        private readonly string[] _paths = new string[] { "Precision", "Domination", "Sorcery", "Resolve", "Inspiration" };

        private readonly string[] _keyStonesPrecision = new string[] { "Press the Attack", "Lethal Thempo", "Fleet Footwork", "Conqueror" };
        private readonly string[] _keyStonesDomination = new string[] { "Electrocute", "Predator", "Dark Harvest", "Hail of Blades" };
        private readonly string[] _keyStonesSorcery = new string[] { "Summon Aery", "Arcane Comet", "Phase Rush" };
        private readonly string[] _keyStonesResolve = new string[] { "Grasp", "Aftershock", "Guardian" };
        private readonly string[] _keyStonesInspiration = new string[] { "Glacial Augment", "Unsealed Spellbook", "First Strike" };

        private readonly string[] _slotOnePrecision = new string[] { "Overheal", "Triumph", "Presence of Mind" };
        private readonly string[] _slotTwoPrecision = new string[] { "Alacrity", "Tenacity", "Bloodline" };
        private readonly string[] _slotThreePrecision = new string[] { "Coup de grace", "Cut Down", "Last Stand" };

        private readonly string[] _slotOneDomination = new string[] { "Cheap Shot", "Taste of blood", "Sudden Impact" };
        private readonly string[] _slotTwoDomination = new string[] { "Zombie ward", "Ghost Poro", "Eyeball Collection" };
        private readonly string[] _slotThreeDomination = new string[] { "Treasure Hunter", "Ingenious Hunter", "Relentless Hunter", "Ultimate Hunter" };

        private readonly string[] _slotOneSorcery = new string[] { "Nullifying Orb", "Manaflow Band", "Nimbus Cloak" };
        private readonly string[] _slotTwoSorcery = new string[] { "Transcendence", "Celerity", "Absolute Focus" };
        private readonly string[] _slotThreeSorcery = new string[] { "Scorch", "Waterwalking", "Gathering Storm" };

        private readonly string[] _slotOneResolve = new string[] { "Demolish", "Front of Life", "Shield Bash" };
        private readonly string[] _slotTwoResolve = new string[] { "Conditioning", "Second Wind", "Bone Plating" };
        private readonly string[] _slotThreeResolve = new string[] { "Overgrowth", "Revitalize", "Unflinching" };

        private readonly string[] _slotOneInspiration = new string[] { "HewFlash", "Magic Footwear", "Perfect Timing" };
        private readonly string[] _slotTwoInspiration = new string[] { "Future's Market", "Dematerializer", "Biscuit" };
        private readonly string[] _slotThreeInspiration = new string[] { "Cosmic Insight", "Approach Velocity", "Time Warp Tonic" };

        private string[]? _keyStones;
        private string[]? _slotOne;
        private string[]? _slotTwo;
        private string[]? _slotThree;
        #endregion

        #region GETTER/SETTER
        public string[] GetPath
        {
            get { return _paths; }
        }
        private string[] KeyStones
        {
            get { return _keyStones; }
            set { _keyStones = value; }
        }
        private string[] SlotOne
        {
            get { return _slotOne; }
            set { _slotOne = value; }
        }
        private string[] SlotTwo
        {
            get { return _slotTwo; }
            set { _slotTwo = value; }
        }
        private string[] SlotThree
        {
            get { return _slotThree; }
            set { _slotThree = value; }
        }

        public Dictionary<string, string[]> GetKeyStones()
        {
            var keyStones = new Dictionary<string, string[]>()
            {
                { "Precision",_keyStonesPrecision },
                { "Domination",_keyStonesDomination },
                { "Sorcery",_keyStonesSorcery },
                { "Resolve",_keyStonesResolve },
                { "Inspiration",_keyStonesInspiration }
            };
            return keyStones;
        }
        public Dictionary<string, string[]> GetSlotOnes()
        {
            var slotOnes = new Dictionary<string, string[]>()
            {
                { "Precision",_slotOnePrecision },
                { "Domination",_slotOneDomination },
                { "Sorcery",_slotOneSorcery },
                { "Resolve",_slotOneResolve },
                { "Inspiration",_slotOneInspiration }
            };
            return slotOnes;
        }
        public Dictionary<string, string[]> GetSlotTwos()
        {
            var slotTwos = new Dictionary<string, string[]>()
            {
                { "Precision",_slotTwoPrecision },
                { "Domination",_slotTwoDomination },
                { "Sorcery",_slotTwoSorcery },
                { "Resolve",_slotTwoResolve },
                { "Inspiration",_slotTwoInspiration }
            };
            return slotTwos;
        }
        public Dictionary<string, string[]> GetSlotThrees()
        {
            var slotThree = new Dictionary<string, string[]>()
            {
                { "Precision",_slotThreePrecision },
                { "Domination",_slotThreeDomination },
                { "Sorcery",_slotThreeSorcery },
                { "Resolve",_slotThreeResolve },
                { "Inspiration",_slotThreeInspiration }
            };
            return slotThree;
        }


        public string[] GetPathKeyStones(string path)
        {
            if (path== "Precision") KeyStones = _keyStonesPrecision;
            if (path== "Domination")KeyStones = _keyStonesDomination;
            if (path == "Sorcery") KeyStones = _keyStonesSorcery;
            if (path == "Resolve") KeyStones = _keyStonesResolve;
            if (path == "Inspiration") KeyStones = _keyStonesInspiration;
            return KeyStones;
        }
        public string[] GetPathSlotOnes(string path)
        {
            if (path == "Precision") SlotOne = _slotOnePrecision;
            if (path == "Domination") SlotOne = _slotOneDomination;
            if (path == "Sorcery") SlotOne = _slotOneSorcery;
            if (path == "Resolve") SlotOne = _slotOneResolve;
            if (path == "Inspiration") SlotOne = _slotOneInspiration;
            return SlotOne;
        }
        public string[] GetPathSlotTwos(string path)
        {
            if (path == "Precision") SlotTwo = _slotTwoPrecision;
            if (path == "Domination") SlotTwo = _slotTwoDomination;
            if (path == "Sorcery") SlotTwo = _slotTwoSorcery;
            if (path == "Resolve") SlotTwo = _slotTwoResolve;
            if (path == "Inspiration") SlotTwo = _slotTwoInspiration;
            return SlotTwo;
        }
        public string[] GetPathSlotThrees(string path)
        {
            if (path == "Precision") SlotThree = _slotThreePrecision;
            if (path == "Domination") SlotThree = _slotThreeDomination;
            if (path == "Sorcery") SlotThree = _slotThreeSorcery;
            if (path == "Resolve") SlotThree = _slotThreeResolve;
            if (path == "Inspiration") SlotThree = _slotThreeInspiration;
            return SlotThree;
        }
        #endregion
    
    public static string GetPathFromNumber(int number, string[] keyStones)
        {
            return keyStones[number];
        }
    }
}
