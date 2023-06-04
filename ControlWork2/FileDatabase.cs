using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork2
{
    internal class FileDatabase
    {
        static List<T> ReadFromFile<T>(string path) where T: ISerializeble, new()
        {
            List<T> list = new List<T>();
            using (var reader = new StreamReader(path, Encoding.UTF8))
            {
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    T obj = new T();
                    obj.Deserialize(str);

                    list.Add(obj);
                }
            }
            return list;
        }

        static void SaveToFile<T>(string path, List<T> objects) where T : ISerializeble, new()
        {
            using (var writer = new StreamWriter(path, false))
            {
                foreach (var obj in objects)
                {
                    string str = obj.Serialize();
                    writer.WriteLine(str);
                }
            }
        }
    }
}
