using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Example19
{  
    public static class SerializeWrapper
    {
        public static string fileName = "DataFile.dat";

        public static void binarySerialize(Users data)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, data);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        public static Users binaryDeserialize()
        {

            Users UsersClass = null;
            FileStream fs = new FileStream(fileName, FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                UsersClass = (Users)formatter.Deserialize(fs);
                return UsersClass;
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

    }

    [Serializable]
    public class Users
    {
        public string userName { get; set; }
        public string email { get; set; }
        public string country { get; set; }    

        public Users(string userName, string email, string country) {
            this.userName = userName;
            this.email = email;
            this.country = country;
        }

    }
}
