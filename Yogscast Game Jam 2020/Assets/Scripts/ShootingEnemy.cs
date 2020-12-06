using UnityEngine;

public class ShootingEnemy : Enemy
{
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;

    float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject projectile;

    Transform player;
    Animator anim;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        timeBtwShots = startTimeBtwShots;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(player != null)
		{
            if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
                anim.SetBool("isRunning", true);
            }
            else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
            {
                transform.position = this.transform.position;
                anim.SetBool("isRunning", false);
            }
            else if (Vector2.Distance(transform.position, player.position) > retreatDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
                anim.SetBool("isRunning", false);
            }

            if (timeBtwShots <= 0)
            {
                Instantiate(projectile, transform.position, Quaternion.identity);
                timeBtwShots = startTimeBtwShots;
            }
            else
            {
                timeBtwShots -= Time.deltaTime;
            }
        }
    }
}
