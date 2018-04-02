//Binary Serialization - code example
//Farid Naisan 2010

using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace SerializationExProjCS
{
    /// <summary>
    /// A utility class that can be used to serialize any object to a file
    /// </summary>
    /// <remarks></remarks>
    public class BinaryFileSerializer
    {
        /// <summary>
        /// Function serializing any type of object 
        /// </summary>
        /// <param name="obj"> Object to be serialized. This object 
        /// must be Serializable.</param>
        /// <param name="filePath">File path including the name of the file to be serialized.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool Serialize(object obj, string filePath)
        {
            bool bOK = true;
            FileStream fileObj = null; //declare fileObj as type FileStream, set to null
            try
            {
                //Steps in serializing an object
                fileObj = new FileStream(filePath, FileMode.Create); //create fileObj
                BinaryFormatter binFormatter = new BinaryFormatter(); //declare and create binFormatter as type BinaryFormatter
                binFormatter.Serialize(fileObj, obj); // serialize and save obj in fileObj
            }
            catch //no parameter - catch avoids exception throwing but no action is taken here 
            {
                bOK = false;
            }
            finally
            {
                if (fileObj != null)              
                    fileObj.Close();
                
            }
            return bOK;
        }

        /// <summary>
        /// Generic method for deserializing any type of object 
        /// </summary>
        /// <typeparam name="T"> Any object</typeparam>
        /// <param name="filepath">File path including the name of the file to be deserialized</param>
        /// <returns></returns>
        /// <remarks>Object must not have changed its structure since it was serilized calling
        /// the above method.</remarks>
        public static T Deserialize<T>(string filepath)
        {
            FileStream fileObj = null;
            object obj = null;

            try
            {
                if (!File.Exists(filepath))
                {
                    throw new FileNotFoundException("The file is not found. ", filepath); //create object
                }

                fileObj = new FileStream(filepath, FileMode.Open); //create fileObj and fill

                BinaryFormatter binFormatter = new BinaryFormatter(); //declare and create binFormatter as type BinaryFormatter
                obj = binFormatter.Deserialize(fileObj); //save object
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.FileName + " -" + ex.Message);
            }
            finally
            {
                if (fileObj != null)
                {
                    fileObj.Close();
                }
            }

            return (T)obj;
        }


    }
}