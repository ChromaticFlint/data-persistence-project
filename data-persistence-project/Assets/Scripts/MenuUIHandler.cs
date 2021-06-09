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

  public void Quit()
  {
#if UNITY_EDITOR
    EditorApplication.ExitPlaymode();
#else
    Application.Quit();
#endif
  }

  public void SaveName()
  {
    nameText.text = username.text.ToString();
  }
}
