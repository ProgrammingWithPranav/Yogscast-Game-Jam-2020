using UnityEngine;

public class EnemyWeaponRotation : MonoBehaviour
{
    public float rotationPerMinute;
    public int damage;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, 0, 6 * rotationPerMinute * Time.deltaTime);
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Player")
		{
            collision.GetComponent<PlayerController>().GetHelth(damage);
		}
	}
}
