using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float health;
    Rigidbody2D rb;
    Animator anim;
    Vector2 moveAmount;
    AudioSource source;
    public AudioClip[] clips;
    public Slider slider;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveAmount = moveInput.normalized * speed;

        if (moveAmount != Vector2.zero)
        {
			if (!source.isPlaying)
			{
                source.clip = clips[0];
                source.Play();
            }
            anim.SetBool("isRunning", true);
        }
        else
        {
            source.Stop();
            anim.SetBool("isRunning", false);
        }
    }

	private void FixedUpdate()
	{
        rb.MovePosition(rb.position + moveAmount * Time.deltaTime);
	}

    public void TakeDamage(int damage)
	{
        health -= damage;
        slider.value = health;
        if(health <= 0)
		{
            source.clip = clips[1];
            source.Play();
            Destroy(gameObject);
        }
	}
}
