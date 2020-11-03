using System;

using System.Collections.Generic;
using System.Text.Json;


namespace oop4
{
    //serializable - сериализация, нужна для сохранения сложных объектов, дисериализация - наоборот
    //metanit: Сериализация представляет процесс преобразования какого-либо объекта в поток байтов
    [Serializable] public class LinkedList<T, U> : ICloneable, GenerInter<T> where T : Inventory
    {
        //=======================================
        //Код ниже - код по восьмой лабе


        private string path;
        public string Path
        {
            get
            {
                return this.path;
            }
        }

        public List<T> CollectionList = new List<T>();

       

        public LinkedList(int size = 10, string path = @"D:\projects\labs\3-semester\oop\oop_8\oop4\sourceFile.txt")
        {
            this.arr = new int[size];
            this.path = path;
        }

        public void Add(T item)
        {
            if (!(item is T))
                throw new Exception("Can't cast U - type to T - type in Add - method");

            this.CollectionList.Add(item as T);
        }
        
        public void Delete(T item)
        {
            if (!(item is T))
                throw new Exception("Can't cast U - type to T - type in Delete - method");
            this.CollectionList.Remove(item as T);
        }

        public void View()
        {
            CollectionList.ForEach((item) => Console.WriteLine(item));
        }
      
       

       

        //=======================================

        //Нижний код - 4-я лаба без перегрузки операторов
        public object Clone()
        {
            return this.MemberwiseClone();
        }

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

        protected int[] arr;

       

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
    }
}
