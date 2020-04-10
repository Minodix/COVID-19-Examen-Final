using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace COVID19
{
    class Data
    {
        private string ruta;
        public  Data(String ruta)
        {
            this.ruta = ruta; 
        }
        public void serializar(List<Registro> registros)
        {
            Stream flujo = File.Open(ruta, FileMode.Create);
            BinaryFormatter binary = new BinaryFormatter();
            binary.Serialize(flujo, registros);
        }
        public List<Registro> deserializar()
        {
            Stream flujo = File.Open(ruta, FileMode.Open);
            BinaryFormatter binary = new BinaryFormatter();
           return (List<Registro>) binary.Deserialize(flujo);
        }
        public static void Guardar(List<Registro> registros)
        {
            Stream stream = File.Open("RegistroDia.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, registros);
            stream.Close();
        }
    }
}
