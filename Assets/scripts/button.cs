using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene("GameScene");
        

    }

    public void quit()
    {
        Application.Quit();
    }
}
