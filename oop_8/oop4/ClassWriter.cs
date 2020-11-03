using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace oop4
{
    //класс отвечающий за запись и чтение объектов 
    public static class ClassWriter<T,U> where T : Inventory
    {
        

        private static BinaryFormatter formatter = new BinaryFormatter();
        

        static public void WriteData(LinkedList<T,U> obj)
        {
            using (FileStream fs = new FileStream(obj.Path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, obj);

                Console.WriteLine("Объект сериализован");
            }

        }

        static public LinkedList<T, U> ReadData(string path)
        {

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                LinkedList<T, U> disValue = (LinkedList<T, U>)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                return disValue;
            }
        }
    }
}
