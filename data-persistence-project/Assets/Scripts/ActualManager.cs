using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ActualManager : MonoBehaviour
{
  public static ActualManager Instance;
  public string Name;
  public int TopScore = 0;
  public string TopScoreName;

  private void Awake()
  {

    if (Instance != null)
    {
      Destroy(gameObject);
      return;
    }

    Instance = this;
    DontDestroyOnLoad(gameObject);
    LoadName();
  }

  [System.Serializable]
  class SaveData
  {
    public string Name;
    public int TopScore;
    public string TopScoreName;
  }

  public void SaveName()
  {
    SaveData data = new SaveData();
    data.Name = Name;
    data.TopScore = TopScore;
    data.TopScoreName = TopScoreName;

    string json = JsonUtility.ToJson(data);

    File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
  }

  public void LoadName()
  {
    string path = Application.persistentDataPath + "/savefile.json";

    if (File.Exists(path))
    {
      string json = File.ReadAllText(path);
      SaveData data = JsonUtility.FromJson<SaveData>(json);

      Name = data.Name;
      TopScore = data.TopScore;
      TopScoreName = data.TopScoreName;
    }
  }

}
