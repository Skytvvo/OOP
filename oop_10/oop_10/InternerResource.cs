using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_10
{
    internal class InternerResource<T> : IList<T> where T:IComparable<T>
    {

        private T[] _content;
        private int _size;
        private int _count;
        public InternerResource(int size)
        {
            if (size <= 0)
                throw new Exception("Invalid excretion of size");

            this._content = new T[size];
            this._size = size;
            this._count = 0;
        }

        public T this[int index] {

            get
            {
                if (index < 0 || index >= _size)
                    throw new Exception("Invalid index");
                return this._content[index];
            }
            set
            {
                if (index < 0 || index >= _size)
                    throw new Exception("Invalid index");
                this._content[index] = value;
            }
        }

        public int Count => this._count;

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }


        public void Add(T item)
        {
            if (this._count == this._size)
            {
                Console.WriteLine("The list is full");
                return;
            }
            this._content[this._count] = item;
            this._count++;
        }

        public void Clear()
        {
            this._content = null;
            this._size = 0;
            this._count = 0;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < this._size; i++)
                if (this._content[i].Equals(item))
                    return true;
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            for(int i = 0; i < this._size; i++)
                array.SetValue(this._content[i], arrayIndex++);
            
        }

        

        public int IndexOf(T item)
        {
            for(int i = 0; i < this._size;i++)
            {
                if (this._content[i].Equals(item))
                    return i;
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            if (index <= this._size && index >= 0 && this._count + 1 <= this._size) 
            {
                this._count++;
                for(int i  = this.Count - 1; i > index; i--)
                {
                    this._content[i] = this._content[i - 1];
                }
                this._content[index] = item;
            }
        }

        public bool Remove(T item)
        {
                RemoveAt(IndexOf(item));
            if(!this.Contains(item))
                return true;
            return false;
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index <= this._count)
            {
                for (int i = index; i < this.Count-1; i++)
                {
                    this._content[i] = this._content[i + 1];
                }
                this._count--;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator() => this._content.Cast<T>().GetEnumerator();
    }
}
