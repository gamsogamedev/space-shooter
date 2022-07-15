using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Bullet projectilePrefab;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float shootTime = 2f;
    [SerializeField] private int damageTaken = 50;

    private GameObject player;
    private Bullet bullet;
    private Life life;
    
    private void Awake()
    {
        life = GetComponent<Life>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Start()
    {
        StartCoroutine(Shoot());
    }
    
    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if (player)
        {
            transform.position = Vector2.MoveTowards(transform.position, 
                player.transform.position, speed * Time.deltaTime);
        }
    }
    
    private IEnumerator Shoot()
    {
        while (player)
        {
            yield return new WaitForSeconds(shootTime);
            bullet = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            bullet.isEnemyBullet = true;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            Destroy(collision.gameObject);
            life.TakeDamage(damageTaken);
        }
    }
}
