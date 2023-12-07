using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class NameHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public static NameHandler Instance;
    public string playerName;
    private void Awake()
    {
        if(Instance!=null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(Instance);
    }
    public string GetCurrName()
    {
        return playerName;
    }
    public string LoadPreviousName()
    {
        string result = "";
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            Data data = JsonUtility.FromJson<Data>(json);
            result = data.farmerName;
        }
        return result;

    }
    public void SaveCurrName()
    {
        Data data = new Data();
        data.farmerName = playerName;
    

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);

    }
    [System.Serializable]
    class Data
    {
        public string farmerName;
        
    }
}
