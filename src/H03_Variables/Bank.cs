namespace H03_Variables{
    //this is a user defined value type
    public struct Bank{
        public string Name { get; set; }
        public string Address { get; set; }
        public ItalianDays ClosedOn { get; set; } //we can combine our types as we want
    }
}