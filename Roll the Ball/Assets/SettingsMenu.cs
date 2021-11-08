using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
    public void Resume()
    {

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
