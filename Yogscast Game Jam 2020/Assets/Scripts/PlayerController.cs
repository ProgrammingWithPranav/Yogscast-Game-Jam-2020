using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
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
}
