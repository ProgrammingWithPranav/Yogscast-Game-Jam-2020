using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalSecretPath : MonoBehaviour
{
    public bool level;
	public string sceneName;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Player")
		{
			if (level)
			{
				SceneManager.LoadScene(sceneName);
			}
			else
			{
				SceneManager.LoadScene(sceneName);
			}
		}
	}
}
