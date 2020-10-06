using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace oop4
{
    public class LinkedList
    {

        public class Owner
        {
            int id;
            string name;
            string companyName;
            public Owner(int id = 0, string name = "Bot", string companyName = "NoName")
            {
                this.id = id;
                this.name = name;
                this.companyName = companyName;
            }
            public int ID
            {
                get
                {
                    return id;
                }

                set
                {
                    this.id = value;
                }
            }

            public string Name
            {
                get
                {
                    return this.name;
                }
                set
                {
                    this.name = value;
                }
            }
            public string CompanyName
            {
                get
                {
                    return this.companyName;
                }
                set
                {
                    this.companyName = value;
                }
            }
        }

        public class Date
        {
            DateTime time = new DateTime();
            public DateTime Time 
            {
                get
                {
                    return time;
                }
                set
                {
                    this.time = value;
                }
            }
            public Date(DateTime time)
            {
                if (time != null)
                    this.time = time;
                else
                    this.time = DateTime.Now;
            }
        }

        private int[] arr; 
    
        public LinkedList(int size = 10)
        {
            arr = new int[size];
        }

        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }


        public static LinkedList operator +(LinkedList A, LinkedList B)
        {
            LinkedList list = new LinkedList();

            for (Node p = A.head; p != null; p = p.next)
                list.AddBack(p.data);
            for (Node p = B.head; p != null; p = p.next)
                list.AddBack(p.data);
            return list;
        }

        public static LinkedList operator !(LinkedList A)
        {
            LinkedList list = new LinkedList();
            for(Node p = A.head; p != null; p = p.next)
            {
                list.AddBack(p.data * (-1));
            }
            return list;
        }

        public static bool operator ==(LinkedList A, LinkedList B)
        {
            
            if (A.Count != B.Count)
                return false;
            for(Node pA = A.head, pB = B.head; pA != null; pA=pA.next, pB = pB.next)
            {
                if (pA.data != pB.data)
                    return false;
            }
            return true;
        }
        public static bool  operator !=(LinkedList A, LinkedList B)
        {
            if (A.Count == B.Count)
                return false;
            for (Node pA = A.head, pB = B.head; pA != null; pA = pA.next, pB = pB.next)
            {
                if (pA.data == pB.data)
                    return false;
            }
            return true;
        }

        public static LinkedList operator <( LinkedList result, LinkedList item)
        {

            for(Node p = item.head; p!= null; p = p.next)
            {
                result.AddBack(p.data);
            }
            return result;
        }
        
        //Next overload only because error
        public static LinkedList operator >(LinkedList result, LinkedList item)
        {
            return result;
        }

       


        

        
        public class Node
        {
            public int data;
            public Node next;

            public Node(int data, Node next)
            {
                this.data = data;
                this.next = next;
            }
        }

        private int count = 0;
        private Node head = null;
        public Node Head
        {
            get
            {
                return this.head;
            }
        }

        private Node tail = null;


        public void AddBack(int data)
        {
            if (head == null)
            {
                head = new Node(data, null);
                tail = head;
            }

            else
            {
                tail.next = new Node(data, null);
                tail = tail.next;
            }

            ++count;
        }

        private void AddFront(int data)
        {
            if (head == null)
            {
                head = new Node(data, null);
                tail = head;
            }

            else
            {
                Node new_node = new Node(data, head);
                head = new_node;
            }

            ++count;
        }

        public void Insert(int index, int data)
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException();

            if (index == 0)
            {
                AddFront(data);
            }

            else
            {
                Node r = head;

                for (int i = 1; i < index; ++i)
                    r = r.next;

                Node new_node = new Node(data, r.next);
                r.next = new_node;

                ++count;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (Node r = head; r != null; r = r.next)
                yield return r.data;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

