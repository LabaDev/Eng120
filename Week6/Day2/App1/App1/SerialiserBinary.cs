using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialisationApp
{
    internal class SerialiserBinary
    {
        public void SerialisToFile<T>(string filePath, T item)
        {
            //Stream or FileStream
            FileStream fileStream  = File.Create(filePath);
            //Create a BinaryFormatter object and use it tot serailase the item to file
            BinaryFormatter writer = new BinaryFormatter();
            //Serialise
            writer.Serialize(fileStream, item);
            fileStream.Close(); 
        }

        public T DeserialiserFromFile<T>(string filePath)
        {
           // Create a stram object for reading
           Stream fileStream = File.OpenRead(filePath);
            BinaryFormatter reader = new BinaryFormatter();
            var deserialised = (T)reader.Deserialize(fileStream);
            fileStream.Close();
            return deserialised;



        }
    }
}
