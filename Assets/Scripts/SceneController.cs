using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject canvasGameOver;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    public void gameOver()
    {
        canvasGameOver.SetActive(true);
        Time.timeScale = 0;
    }

   public void gameReset()
    {
        SceneManager.LoadScene(0);
    }
}
