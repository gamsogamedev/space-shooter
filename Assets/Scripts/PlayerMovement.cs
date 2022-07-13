using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private Vector2 movement;
    private Rigidbody2D rb2D;
    
    private float horizontal;
    private float vertical;
    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    
    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        
        movement = new Vector2(horizontal, vertical);
    }
    
    private void FixedUpdate()
    {
        rb2D.velocity = movement * speed;
    }
}
