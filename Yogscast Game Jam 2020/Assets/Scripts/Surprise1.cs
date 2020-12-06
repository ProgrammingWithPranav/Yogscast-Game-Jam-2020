using UnityEngine;

public class Surprise1 : MonoBehaviour
{
    public static bool isFirstTime;

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
}
