namespace School
{
    public class Teacher : Person // IS A 
    {
        public decimal Salary { get; set; }
        public Course CurrentlyTeachingCourse { get; set; }
        public override string SayHi() //if the SayHi of our base class was abstract, we could leave this implementation out
        {
            return $"Hi My Name is {Name} and My Salary Is {Salary} And I Teach {CurrentlyTeachingCourse}";
        }

        public override string ToString(){ //Object gives us the chance to override ToString (implicitly called by WriteLine)
            return $"Teacher {Name} ({Salary}) teaching {CurrentlyTeachingCourse}";
        } 
    }
}