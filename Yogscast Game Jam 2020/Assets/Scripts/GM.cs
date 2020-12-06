using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public void Play()
	{
		SceneManager.LoadScene(2);
	}

	public void OpenChannel()
	{
		Application.OpenURL("https://www.youtube.com/channel/UCJwogTIbU1K2BOLZUVfzp8w");
	}

	public void OpenWebsite()
	{
		Application.OpenURL("http://pranavtantri.tech/");
	}
}
