using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
   public void Restart()
    {
        //SceneManager.LoadScene(0);
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
}
