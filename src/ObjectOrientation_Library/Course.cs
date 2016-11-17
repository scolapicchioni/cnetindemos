namespace School
{
    public class Course
    {
        public int Id { get ;}
        public string Name { get; }
        //we remove the default constructor so that a Course has to be instantiated with id and name
        //we make the constructor internal so that only a class in this package can access to it
        internal Course(int id, string name) 
        {
            Id = id;   
            Name = name;
        }

        public override string ToString(){
            return $"Course {Id} - {Name}";
        } 
    }
}
