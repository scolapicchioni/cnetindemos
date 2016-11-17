using System;

namespace School{
    public class CourseCollection{
        private Course[] items = new Course[10];
        private int count = 0;
        public int Count => count; //C#6 shortcut for a read only property

        //indexer
        public Course this[int index] => items[index]; //C# 6 shortcut syntax

        public Course Set(string courseName){
            Course result = Array.Find(items, c=>c?.Name==courseName);
            if(result==null){
                result = new Course(count+1, courseName);
                //TODO: eventually enlarge the list if no room is available
                items[count++] = result;
            }
            return result;
        }
    }
}