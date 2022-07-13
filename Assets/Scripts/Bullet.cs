using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private Vector2 direction = Vector2.up;
    
    private void Start()
    {
        Destroy(gameObject, 5f);
    }
    
    private void Update()
    {
        transform.Translate(speed * 
                            Time.deltaTime * direction);
    }
}
