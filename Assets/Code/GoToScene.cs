using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
	[SerializeField] int sceneNum;
	private void OnTriggerEnter2D(Collider2D collision)
	{ if (collision.gameObject.tag == "Player")
		{
			SceneManager.LoadScene(sceneNum);
			PlayerPrefs.SetInt("LevelNumber",SceneManager.GetActiveScene().buildIndex);
		}
        if (collision.gameObject.tag=="Bullet")
        {
			Destroy(this.gameObject);
        }
	}
}
