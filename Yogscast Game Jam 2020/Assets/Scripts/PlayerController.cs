using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float health;
    Rigidbody2D rb;
    Animator anim;
    Vector2 moveAmount;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveAmount = moveInput.normalized * speed;

        if (moveAmount != Vector2.zero)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
    }

	private void FixedUpdate()
	{
        rb.MovePosition(rb.position + moveAmount * Time.deltaTime);
	}

    public void GetHelth(int damage)
	{
        health += damage;
        if(health <= 0)
		{
            print("Player is dead!!");
		}
	}
}
