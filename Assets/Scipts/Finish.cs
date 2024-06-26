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
        int nivelactual = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(nivelactual + 2);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "cambio")
        {
            Cambio();
        }
    }
}
