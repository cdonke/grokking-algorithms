namespace Selection_Sort
{
    class Music
    {
        public Music() { }
        public Music(string BandName, int Listens)
        {
            this.BandName = BandName;
            this.Listens = Listens;
        }
        public string BandName
        {
            get;
            set;
        }

        public int Listens
        {
            get;
            set;
        }
    }
}
