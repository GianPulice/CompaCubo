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
    [ContextMenu("cambiar nivel")]
    public void nextlevel()
    {
        int LevelNow = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(LevelNow+1);
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "next")
        {
            int LevelNow = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(LevelNow + 1);
        }
    }
}
