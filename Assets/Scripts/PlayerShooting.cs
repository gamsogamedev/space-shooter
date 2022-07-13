using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float delay = 0.5f;
    [SerializeField] private Transform bulletSpawn;

    private bool shooting;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (shooting == false)
            {
                StartCoroutine(Shoot());
            }
        }
    }

    private IEnumerator Shoot()
    {
        shooting = true;
        Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity);
        yield return new WaitForSeconds(delay);
        shooting = false;
    }
}
