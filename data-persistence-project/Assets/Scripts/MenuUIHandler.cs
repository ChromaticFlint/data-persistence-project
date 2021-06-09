using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
  public Text nameText;
  public InputField username;

  public void StartNew()
  {
    SceneManager.LoadScene(1);
  }

  public void Start()
  {
    if (ActualManager.Instance.Name != null)
    {
      nameText.text = ActualManager.Instance.Name;
    }
  }

  public void Quit()
  {
#if UNITY_EDITOR
    ActualManager.Instance.SaveName();
    EditorApplication.ExitPlaymode();
#else
    ActualManager.Instance.SaveName();
    Application.Quit();
#endif
  }

  public void SaveName()
  {
    nameText.text = username.text.ToString();
    ActualManager.Instance.Name = nameText.text;
  }

  public void ClearName()
  {
    nameText.text = "";
    username.text = "";
    ActualManager.Instance.Name = "";
  }
}
