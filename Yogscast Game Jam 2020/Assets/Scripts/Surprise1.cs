using System.Collections;
using UnityEngine;

public class Surprise1 : MonoBehaviour
{
    public static bool isFirstTime;
	public GameObject text;

	private void Start()
	{
		isFirstTime = true;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Player")
		{
			if (isFirstTime)
			{
				Time.timeScale = 0;
				text.SetActive(true);
				Time.timeScale = 1;

				StartCoroutine("setText");
				text.SetActive(false);

				print("Surprise!");
				SetSurpriseToFalse();
				FindObjectOfType<Surprise1>().SetSurpriseToFalse();
			}
		}
	}

	public void SetSurpriseToFalse()
	{
		isFirstTime = false;
	}

	IEnumerator setText()
	{
		yield return new WaitForSeconds(1);
	}
}
