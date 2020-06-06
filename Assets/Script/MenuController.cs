using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour


{
    public void PlayGame()
    {
        //Application.LoadLevel("Level1");

        // nếu muốn dùng lại giao diện trước khi chuyển màng hình thì ta dùng  LoadSceneMode.Additive
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
        Time.timeScale = 1;

    }

    public void QuitGame()
    {
        //print("Quit Game");
        //  Application.Quit();
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
        Time.timeScale = 1;
    }


}
