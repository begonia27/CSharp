namespace Indexers
{
    // struct PhoneNumber
    // {
    //     public PhoneNumber(string text)
    //     {
    //         Text = text;
    //     }
    //
    //     public string Text { get; }
    // }
    
    struct PhoneNumber
    {
        private string number;
    
        public PhoneNumber(string text)
        {
            number = text;
        }
    
        public string Text => number;
        
        public override int GetHashCode() => number.GetHashCode();

        public bool Equals(PhoneNumber other) => number == other.number;
    }
}
