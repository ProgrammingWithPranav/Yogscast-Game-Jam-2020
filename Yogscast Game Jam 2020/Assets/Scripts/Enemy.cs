using UnityEngine;

public class Enemy : MonoBehaviour
{
	public int damage;
	AudioSource source;

	private void Start()
	{
		source = GetComponent<AudioSource>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Player")
		{
			collision.GetComponent<PlayerController>().TakeDamage(damage);
			Destroy(gameObject);
		}

		if(collision.tag == "Weapon")
		{
			source.Play();
			Destroy(gameObject);
		}
	}
}
