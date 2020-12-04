using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem 
{
    public static void SavePlayer (){
        BinaryFormatter formatter = new BinaryFormatter(); //create a binary formatter
        /*
        string path="C:/System/" //The path will depend on the system
        */
        string path = Application.persistentDataPath +"/player.fun";
        //This function is going to get a path to a data directory on the operating system
        //that isn't going to suddenly change. Then we can add anything to this maybe by
        //creating a file called player. Because we are making our own file and it is just a 
        //binary file, we can name the file tyep whatever we want.

        //Next use the file stream, a file stream is a stream of data contained in the file
        //and we use a particular file stream to read and write from a file
        FileStream stream = new FileStream(path,FileMode.Create);
        //FileMode is where we want to opena  file or create one file into an already existing file
        //Now the file is created

        PlayerData data = new PlayerData(); // Data we want to save

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData LoadPlayer(){
        string path = Application.persistentDataPath +"/player.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();
            return data;
            
        }else{
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
