using System;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public int damage;

    Transform player;
    Vector2 target;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        target = new Vector2(player.position.x, player.position.y);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if(transform.position.x == target.x && transform.position.y == target.y)
		{
            player.GetComponent<PlayerController>().GetHelth(damage);
            DestroyProjectile();
		}
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Player")
		{
            collision.GetComponent<PlayerController>().GetHelth(damage);
            DestroyProjectile();
        }
	}

	private void DestroyProjectile()
	{
        Destroy(gameObject);
	}
}
