using System;
using System.Text;
namespace GenericClass
{
    public class GenericList<T> where T : IComparable
    {
        //Constants
        private const int InitialSize = 8;

        //Fields
        private T[] data;
        private int count;

        //constructor
        public GenericList()
            : this(InitialSize)
        {

        }

        public GenericList(int initialSize)
        {
            if (initialSize <= 0)
            {
                throw new ArgumentException("Initial size of GenericList must be greater than 0");
            }

            //set the initial size as specified
            this.data = new T[initialSize];

            //set the count to 0
            this.count = 0;
        }

        //Properties
        public int Capacity
        {
            get
            {
                return this.data.Length;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        //Methods

        /// <summary>
        /// Add element to GenericList
        /// </summary>
        /// <param name="item">Item to be added</param>
        public void Add(T item)
        {
            if (count == this.Capacity)
            {
                this.ResizeData();
            }

            this.data[this.count] = item;
            count++;
        }


        /// <summary>
        /// Insert Element at given position
        /// </summary>
        /// <param name="index">Index where the element will be inserted</param>
        /// <param name="item">Item to be inserted</param>
        public void Insert(int index, T item)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }


            //ensure capacity
            while (index >= this.Capacity)
            {
                this.ResizeData();
            }

            if (index > this.Count) //add element after already added ones without throwing exception
            {
                this.data[index] = item;
                this.count = index + 1;
            }
            else
            {
                if ((this.Count + 1) >= this.Capacity) //ensure that there is enough space
                {
                    this.ResizeData();

                }
                Array.Copy(this.data, index, this.data, index + 1, this.Count - index);
                this.data[index] = item;
                this.count++;
            }
        }

        /// <summary>
        /// Removes element at specified index
        /// </summary>
        /// <param name="index">Zero based index</param>
        public void RemoveAt(int index)
        {

            if (this.Count == 0)
            {
                throw new ArgumentNullException("The GenericList is empty");
            }

            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }

            this.count--;

            Array.Copy(this.data, index+1, this.data, index, this.Count - index);

            
        }

        /// <summary>
        /// Removes all elements from GenericList
        /// </summary>
        public void Clear()
        {
            this.data = new T[InitialSize];
            this.count = 0;
        }

        //Indexing
        public T this[int index]
        {
            get
            {
                if (index >= this.Count)
                {
                    throw new IndexOutOfRangeException("Index was out of GenericList range");
                }

                return this.data[index];
            }
            set
            {
                while (index >= this.Capacity)
                {
                    this.ResizeData();
                }

                if (index >= this.Count)
                {
                    this.count = index + 1;
                }

                this.data[index] = value;

            }
        }

        /// <summary>
        /// Returns index of element
        /// </summary>
        /// <param name="item">Item to find</param>
        /// <returns>The zero-based index of the first occurrence of value within the entire array,
        /// if found; otherwise, –1</returns>
        public int Find(T item)
        {
            return Array.IndexOf(this.data, item);
        }

        /// <summary>
        /// Finds Min element from GenericList
        /// </summary>
        /// <returns>Found minimal element</returns>
        public T Min()
        {
            if (this.Count == 0)
            {
                throw new ArgumentNullException("GenericList is empty");
            }

            int min = 0;

            for (int i = 1; i < this.Count; i++)
            {
                if (this.data[i].CompareTo(this.data[min]) < 0)
                {
                    min = i;
                }
            }

            return this.data[min];
        }

        /// <summary>
        /// Finds Max element from GenericList
        /// </summary>
        /// <returns>Found max element</returns>
        public T Max()
        {
            if (this.Count == 0)
            {
                throw new ArgumentNullException("GenericList is empty");
            }

            int max = 0;

            for (int i = 1; i < this.Count; i++)
            {
                if (this.data[i].CompareTo(this.data[max]) > 0)
                {
                    max = i;
                }
            }

            return this.data[max];
        }


        //resize the support array
        private void ResizeData()
        {
            int newSize = this.Capacity * 2;

            while (this.count >= newSize)
            {
                newSize *= 2;
            }

            T[] newData = new T[newSize];

            Array.Copy(this.data, newData, this.Count);

            this.data = newData;
        }

        public override string ToString()
        {
            string[] info = new string[this.count];

            for (int i = 0; i < this.Count; i++)
            {
                info[i] = this.data[i].ToString();
            }

            return "{ " + string.Join(", ", info) + " }";
        }

    }
}
