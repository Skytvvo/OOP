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
    public static class ClassWriter<T> where T : class
    {
        private static BinaryFormatter formatter;
        

        static ClassWriter()
        {
            formatter = new BinaryFormatter();
        }

        static public void WriteData(LinkedList<T> obj)
        {
            using (FileStream fs = new FileStream(obj.Path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, obj);
            }
        }

        static public LinkedList<T> ReadData(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                LinkedList<T> disValue = (LinkedList<T>)formatter.Deserialize(fs);
                return disValue;
            }
        }
    }
}
