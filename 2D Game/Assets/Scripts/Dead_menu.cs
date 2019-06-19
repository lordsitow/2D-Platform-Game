using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead_menu : MonoBehaviour
{
    public void back_to_main_menu()
    {
        SceneManager.LoadScene(0);
    }
    public void try_again()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("last_scene"));
    }
}
