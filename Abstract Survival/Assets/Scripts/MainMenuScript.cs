using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public void onMouseEnter(Text TextObject)
    {
        TextObject.fontSize = 80;
    }
    public void onMouseExit(Text TextObject)
    {
        TextObject.fontSize = 70;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
