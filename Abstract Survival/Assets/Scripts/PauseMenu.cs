using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseScreen;
    public bool isActive;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isActive)
            {
                PauseScreen.SetActive(false);
                Time.timeScale = 1;
                isActive = false;
            }
            else
            {
                PauseScreen.SetActive(true);
                Time.timeScale = 0;
                isActive = true;
            }
        }
    }
}
