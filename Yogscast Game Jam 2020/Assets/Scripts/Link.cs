using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour
{

	public void OpenYoutubeChannel()
	{
#if !UNITY_EDITOR
		openWindow("https://www.youtube.com/channel/UCJwogTIbU1K2BOLZUVfzp8w");
#endif
	}

	public void OpenWebsite()
	{
#if !UNITY_EDITOR
		openWindow("http://pranavtantri.tech/");
#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

}