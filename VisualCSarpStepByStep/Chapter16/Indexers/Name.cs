namespace Indexers
{
    struct Name
    {
        private string name;

        public Name(string text)
        {
            name = text;
        }

        // public string text
        // {
        //     get
        //     {
        //         return name;
        //     }
        // }

        // public string text => name;
        public string Text
        {
            get => name;
        }
        // public override int GetHashCode() => name.GetHashCode();
        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        public override bool Equals(object other) => (other is Name) && Equals((Name)other);

        public bool Equals(Name other) => name == other.name;
    }
}
