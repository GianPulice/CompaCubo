using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CambioNivel()
    {
        SceneManager.LoadScene(2);

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag== "player")
        {
            CambioNivel();
        }
    }
}
