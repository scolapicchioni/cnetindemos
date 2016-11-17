namespace Utilities {
    public class Collection<T>{ //T is just a placeholder that has to be replaced at compile time
        private T[] items = new T[10];
        private int count = 0;
        public int Count => count; //C#6 shortcut for a read only property

        //indexer
        public T this[int index] => items[index]; //C# 6 shortcut syntax

        public void Add(T item){
            //TODO: eventually enlarge the list if no room is available
            items[count++] = item;    
        }
        
    }
}