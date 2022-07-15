using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private int damageTaken = 50;
    
    private Life life;

    private void Awake()
    {
        life = GetComponent<Life>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyBullet") || collision.gameObject.CompareTag("Enemy"))
        {
            if (collision.gameObject.CompareTag("EnemyBullet"))
            {
                Destroy(collision.gameObject);
            }
            life.TakeDamage(damageTaken);
        }
    }
}
