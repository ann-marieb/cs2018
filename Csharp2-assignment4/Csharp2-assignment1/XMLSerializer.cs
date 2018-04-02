/// XMLSerializer.cs
/// Ann-Marie Bergström  ai2436 2018

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Csharp2_assignment
{
    class XMLSerializer
    {
        public static void Serialize<T>(string xmlFileName, object obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextWriter writer = new StreamWriter(xmlFileName);
            try
            {
                serializer.Serialize(writer, obj);
            }
            finally
            {
                if (writer != null)

                    writer.Close();
            }
        }

        internal static T DeSerialize<T>(string xmlFileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            object obj = null;

            TextReader reader = null;

            try
            {
                reader = new StreamReader(xmlFileName);
                obj = (T)serializer.Deserialize(reader);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return (T)obj;
        }
    }
}
