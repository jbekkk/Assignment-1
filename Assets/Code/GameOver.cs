using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Restart() {
        SceneManager.LoadScene(PlayerPrefs.GetInt("LevelNumber"));
    }

    public void Exit() {
        SceneManager.LoadScene("Title");
    }
}
