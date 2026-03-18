namespace ConsoleApp1 
{
    partial class MyIndexers<T>
    {
        private T[] items;

        MyIndexers()
        {
            items = new T[10];
        }

        public MyIndexers(int len)
        {
            items = new T[len];
        }

        public T this[int index]
        {
            get
            {
                if(index < 0 || index > items.Length)
                {
                    throw new IndexOutOfRangeException("Index out of range.");
                }
                return items[index];
            }

            set
            {
                if (index < 0 || index > items.Length)
                {
                    throw new IndexOutOfRangeException("Index out of range.");
                }

                items[index] = value;
            }
        }

        public int getLength()
        {
            return items.Length;
        }
    }
}