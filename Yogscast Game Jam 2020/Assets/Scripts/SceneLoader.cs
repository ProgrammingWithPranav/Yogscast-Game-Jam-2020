﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Player")
		{
			SceneManager.LoadScene(sceneName);
		}
	}
}
