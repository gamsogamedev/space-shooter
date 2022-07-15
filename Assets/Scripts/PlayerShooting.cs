using System.Collections;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float delay = 0.1f;
    [SerializeField] private Transform bulletSpawn;
    
    private bool _shooting;

    private void Update()
    {
        if (!Input.GetKey(KeyCode.Space)) return;
        
        if (!_shooting) StartCoroutine(Shoot());
    }
    
    private IEnumerator Shoot()
    {
        _shooting = true;
        Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity);
        yield return new WaitForSeconds(delay);
        _shooting = false;
    }
}
