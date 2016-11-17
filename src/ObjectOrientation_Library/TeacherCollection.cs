using Utilities;

namespace School
{
    public class TeacherCollection : Collection<Teacher>{
        public void Add(string name, decimal salary, Course course){
            Add(new Teacher(){Name = name, Salary=salary, CurrentlyTeachingCourse=course});
        }
    }
}