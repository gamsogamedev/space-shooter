using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 50f;
    
    public bool isEnemyBullet;
    
    private Vector2 _direction = Vector2.up;

    private void Start()
    {
        if (isEnemyBullet)
        {
            transform.tag = "EnemyBullet";
            _direction = Vector2.down;
        }
        else
        {
            transform.tag = "PlayerBullet";
        }
        
        Destroy(gameObject, 5f);
    }

    private void Update()
    {
        transform.Translate( speed * Time.deltaTime * _direction);
    }
}
