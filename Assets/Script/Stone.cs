using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Stone : MonoBehaviour
{
    public static bool isPause = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < -12f)
        {
            Destroy(this.gameObject);
        }     
    }

    void Pause()
    {
        Time.timeScale = 0f;
    }

    void UnPause()
    {
        Time.timeScale = 1f;
    }

    public void GameExit()
    {
        Application.Quit();
    }

    public void GameStartAgain()
    {
        SceneManager.LoadScene(0);
    }

    public void GamePause()
    {
        isPause = !isPause;

        if (isPause)
        {
            Pause();
        }
        else
        {
            UnPause();
        }
    }
}
