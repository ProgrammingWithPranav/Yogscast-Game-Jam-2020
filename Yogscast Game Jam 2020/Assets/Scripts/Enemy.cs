﻿using UnityEngine;

public class Enemy : MonoBehaviour
{
	public int damage;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Player")
		{
			collision.GetComponent<PlayerController>().TakeDamage(damage);
		}
	}
}