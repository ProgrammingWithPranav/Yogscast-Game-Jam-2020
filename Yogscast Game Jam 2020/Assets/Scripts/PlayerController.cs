using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float health;
    Rigidbody2D rb;
    Vector2 moveAmount;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveAmount = moveInput.normalized * speed;
    }

	private void FixedUpdate()
	{
        rb.MovePosition(rb.position + moveAmount * Time.deltaTime);
	}

    public void TakeDamage(int damage)
	{
        health -= damage;
        if(health <= 0)
		{
            print("Player is dead!!");
		}
	}
}
