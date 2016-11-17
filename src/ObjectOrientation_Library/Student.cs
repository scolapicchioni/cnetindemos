namespace School
{
    public class Student : Person //Student IS A Person
    {
        public string Number { get; set; }
        public Course CurrentlyFollowingCourse { get; set; }
        public override string SayHi()
        {
            return $"{Name}";
        }

        public override string ToString(){
            return $"Student {Number} - {Name} following {CurrentlyFollowingCourse}";
        } 

    }
}