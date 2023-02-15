namespace server.Runes
{
    public interface IRunesPage
    {
        // Main Tree
        public string MainPath { get; set; }

        public string KeyStone { get; set; }

        public string SlotOneMain { get; set; }

        public string SlotTwoMain { get; set; }

        public string SlotThreeMain { get; set; }

        // Sedond Tree
        public string SecondPath { get; set; }

        public string SlotOneSecond { get; set; }

        public string SlotTwoSecond { get; set; }


        // Masteries
        public string ShardSlotOne { get; set; }

        public string ShardSlotTwo { get; set; }

        public string ShardSlotThree { get; set; }
    }
}
