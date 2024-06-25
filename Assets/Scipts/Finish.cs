using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public void Exit() 
    {
        Application.Quit();
    }
    public void Cambio()
    {
        SceneManager.LoadScene(4);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Cambio();
        }
    }
}
