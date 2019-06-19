using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_menu : MonoBehaviour
{
    public void Continue()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("last_scene"));
    }

    public void Main_menu()
    {
        SceneManager.LoadScene(0);
    }
}
