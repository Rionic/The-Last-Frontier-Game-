using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void PlayGame ()
  {
     SceneManager.LoadScene("Level 1");
   //Application.LoadLevel("Level 1");
  }

  public void ReturntoTitleScreen ()
  {
    Debug.Log("return asdfs");
     Application.LoadLevel("Title Scene");
  }


public void QuitGame ()
{

  Debug.Log("Quit!");
  Application.Quit();

}


}
