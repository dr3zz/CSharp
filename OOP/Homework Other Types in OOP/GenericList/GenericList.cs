namespace GenericList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Version("1.0.0")]
 
    public class GenericList<T> where T : IComparable<T>
    {
        private const int DefaultCapacity = 16;

        private T[] elements;
        private int count = 0;
        private int extendedCapacity = 0;

        public GenericList()
        {
            this.elements = new T[DefaultCapacity];
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.count)
                {
                    throw new IndexOutOfRangeException();
                }

                return this.elements[index];
            }
        }

        public T Min()
        {
            if (this.count < 1)
            {
                throw new InvalidOperationException("This list is empty");
            }

            T min = this.elements[0];
            for (int i = 1; i < this.count; i++)
            {
                if (this.elements[i].CompareTo(min) <= 0)
                {
                    min = this.elements[i];
                }
            }

            return min;
        }

        public T Max()
        {
            if (this.count < 1)
            {
                throw new InvalidOperationException("This list is empty");
            }

            T max = this.elements[0];
            for (int i = 1; i < this.count; i++)
            {
                if (this.elements[i].CompareTo(max) >= 0)
                {
                    max = this.elements[i];
                }
            }

            return max;
        }

        public void Add(T element)
        {
            if (this.count >= this.extendedCapacity)
            {
                this.Expand();
            }

            this.elements[this.count] = element;
            this.count++;
        }

        public T IndexOf(int index)
        {
            if (index < 0 || index > this.count)
            {
                throw new IndexOutOfRangeException(string.Format("Invalid index: {0}.", index));
            }

            T result = this.elements[index - 1];
            return result;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > this.count)
            {
                throw new IndexOutOfRangeException(string.Format("Invalid index: {0}.", index));
            }

            T[] newElements = new T[this.elements.Length];
            int count = 0;
            for (int i = 0; i < this.count; i++)
            {
                if (index - 1 != i)
                {
                    newElements[count] = this.elements[i];
                    count++;
                }
            }

            this.elements = newElements;
            this.count--;
        }

        public void InsertAt(T element, int index)
        {
            if (index < 0 || index > this.count)
            {
                throw new IndexOutOfRangeException(string.Format("Invalid index: {0}.", index));
            }

            if (this.count >= this.extendedCapacity)
            {
                this.Expand();
            }

            T[] newElements = new T[this.elements.Length];
            int count = 0;
            for (int i = 0; i < this.count; i++)
            {
                if (index - 1 != i)
                {
                    newElements[count] = this.elements[i];
                    count++;
                }
                else
                {
                    newElements[count] = element;
                    count++;
                    newElements[count] = this.elements[i];
                    count++;
                }
            }

            this.elements = newElements;
            this.count++;
        }

        public void Clear()
        {
            T[] clearElements = new T[this.extendedCapacity];
            this.elements = clearElements;
            this.count = 0;
        }

        public int Find(T element)
        {
            int num = 0;
            for (int i = 0; i < this.count; i++)
            {
                if (element.Equals(this.elements[i]))
                {
                    num = i + 1;
                }
            }

            if (num == 0)
            {
                Console.WriteLine("Element \"{0}\" not found", element);
            }

            return num;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (element.Equals(this.elements[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for (int i = 0; i < this.count; i++)
            {
                sb.Append((i + 1) + " => " + this.elements[i] + ", ");
            }

            int stringBuilderLength = sb.Length - 2;
            sb.Remove(stringBuilderLength, 2);
            sb.Append("]");
            return sb.ToString();
        }

        private void Expand()
        {
            if (this.extendedCapacity < DefaultCapacity)
            {
                this.extendedCapacity = DefaultCapacity;
            }

            this.extendedCapacity = this.extendedCapacity * 2;
            T[] newElements = new T[this.extendedCapacity];
            for (int i = 0; i < this.count; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
            //// throw new IndexOutOfRangeException(string.Format(
            //// "The list capacity of {0} was exceeded.", this.elements.Length));
        }
    }
}
