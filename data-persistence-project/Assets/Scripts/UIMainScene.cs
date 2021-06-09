using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMainScene : MonoBehaviour
{
  public void QuitToMenu()
  {
    SceneManager.LoadScene(0);
    ActualManager.Instance.SaveName();
  }

}
