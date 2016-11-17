using Utilities;

namespace School
{
    public class StudentCollection : Collection<Student>{
        public void Add(string name, string number, Course course){
            Add(new Student(){Name = name, Number=number, CurrentlyFollowingCourse=course});
        }
    }
}