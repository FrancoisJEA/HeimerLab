using server.Champion;
using System.Xml.Linq;

namespace server.Runes
{
    public class RunesPage : IRunesPage
    {
        private string _name,_pathMain, _keyStone, _slotOneMain, _slotTwoMain, _slotThreeMain, _pathSecond, 
            _slotOneSecond, _slotTwoSecond, _shardOne, _shardTwo, _shardThree; 
        private IChampion? _champion;
        private RunesItems Runes { get;  set; }

        public RunesPage(string name ,int pathMain,int keyStone , int OneMain, int TwoMain, int ThreeMain, int pathSecond, 
            int OneSecond,int  TwoSecond,int shardOne, int shardTwo, int shardThree) 
        {
            _name= name;
            _pathMain = RunesItems.GetPathFromNumber(pathMain, Runes.GetPath);
            _keyStone = this.GetKeyStoneFromNumber(keyStone);
            _slotOneMain = this.GetSlotOneMainFromNumber(OneMain);
            _slotTwoMain = this.GetSlotTwoMainFromNumber(TwoMain);
            _slotThreeMain = this.GetSlotThreeMainFromNumber(ThreeMain);

            _pathSecond = RunesItems.GetPathFromNumber(pathSecond, Runes.GetPath);
            _slotOneSecond = this.GetSlotOneSecondFromNumber(OneSecond);
            _slotTwoSecond = this.GetSlotTwoSecondFromNumber(TwoSecond);
            _shardOne = GetShardOneFromNumber(shardOne);
            _shardTwo = GetShardTwoFromNumber(shardTwo);
            _shardThree = GetShardThreeFromNumber(shardThree);
        }
        public RunesPage(string name, string mainPath, string keyStone, string OneMain, string TwoMain, string ThreeMain, string pathSecond,
            string OneSecond, string TwoSecond, string shardOne, string shardTwo, string shardThree)
        {
            _name = name;
            _pathMain = mainPath; _keyStone = keyStone; _slotOneMain = OneMain; _slotTwoMain = TwoMain; _slotThreeMain  = ThreeMain;
            _pathSecond = pathSecond; _slotOneSecond = OneSecond; _slotTwoSecond = TwoSecond;
            _shardOne = shardOne; _shardTwo = shardTwo; _shardThree = shardThree;

        }

        #region GET/SET
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public IChampion Champion 
        { 
            get { return _champion; }
            set { _champion = value; } 
        }
        public string ChampionName
        {
            get { return _champion.Name; }
        }
        // Main Rune Tree
        public string MainPath
        {
            get { return _pathMain; }
            set { _pathMain = value; }
        }
        public string KeyStone
        {
            get { return _keyStone; }
            set { _keyStone = value; }
        }
        public string SlotOneMain
        {
            get { return _slotOneMain; }
            set { _slotOneMain = value; }
        }
        public string SlotTwoMain
        {
            get { return _slotTwoMain; }
            set { _slotTwoMain = value; }
        }
        public string SlotThreeMain
        {
            get { return _slotThreeMain; }
            set { _slotThreeMain = value; }
        }

        // Sedond Tree
        public string SecondPath
        {
            get { return _pathSecond; }
            set { _pathSecond = value; }
        }
        public string SlotOneSecond
        {
            get { return _slotOneSecond; }
            set { _slotOneSecond = value; }
        }
        public string SlotTwoSecond
        {
            get { return _slotTwoSecond; }
            set { _slotTwoSecond = value; }
        }

        // Masteries
        public string ShardSlotOne 
        {
            get { return _shardOne; }
            set { _shardOne = value; }
        }
        public string ShardSlotTwo
        {
            get { return _shardTwo; }
            set { _shardTwo = value; }
        }
        public string ShardSlotThree
        {
            get { return _shardThree; }
            set { _shardThree = value; }
        }

        #endregion
    
        private string GetKeyStoneFromNumber(int number)
        {
            return Runes.GetKeyStones()[MainPath][number];
        }
        private string GetSlotOneMainFromNumber(int number)
        {
            return Runes.GetSlotOnes()[MainPath][number];
        }
        private string GetSlotTwoMainFromNumber(int number)
        {
            return Runes.GetSlotTwos()[MainPath][number];
        }
        private string GetSlotThreeMainFromNumber(int number)
        {
            return Runes.GetSlotThrees()[MainPath][number];
        }
        private string GetSlotOneSecondFromNumber(int number)
        {
            return Runes.GetSlotThrees()[MainPath][number];
        }
        private string GetSlotTwoSecondFromNumber(int number)
        {
            return Runes.GetSlotOnes()[MainPath][number];
        }

        private string GetShardOneFromNumber(int number) { return "aa"; }
        private string GetShardTwoFromNumber(int number) { return "aa"; }
        private string GetShardThreeFromNumber(int number) { return "aa"; }
    }
}
