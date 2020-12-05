using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;

    float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject projectile;

    Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        timeBtwShots = startTimeBtwShots;
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        }
        else if (Vector2.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }

        if(timeBtwShots <= 0)
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
