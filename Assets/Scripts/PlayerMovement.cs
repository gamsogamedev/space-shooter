using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    
    private Rigidbody2D _rigidbody2D;
    private Vector2 _movement;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //float deltaTime = Time.deltaTime;
        float horizontal = Input.GetAxisRaw("Horizontal"); // * deltaTime;
        float vertical = Input.GetAxisRaw("Vertical"); // * deltaTime;
        _movement = new Vector2(horizontal, vertical);
    }
    
    private void FixedUpdate()
    {
        _rigidbody2D.velocity = _movement * speed;
    }
}
