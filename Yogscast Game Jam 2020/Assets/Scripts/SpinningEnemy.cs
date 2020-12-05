using UnityEngine;

public class SpinningEnemy : MonoBehaviour
{
    public float speed;

    Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if (target != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Weapon")
		{
            Destroy(gameObject);
		}
	}
}
