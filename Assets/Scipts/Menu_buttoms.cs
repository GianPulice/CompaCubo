using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_buttoms : MonoBehaviour
{
    

    public void LoadScene()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void QuitGame()
    {

          Application.Quit(); 

    }
}
