using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public void StartGame() {
        SceneManager.LoadScene("lvl_1");
    }

    public void Exit() {
        Application.Quit();
    }
}
