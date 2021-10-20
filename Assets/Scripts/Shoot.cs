using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject laserPrefab;
    [SerializeField]
    private float fireRate = 0.5f;
    private float canFire = -1f;
    

    void Update()
    {
        if (Input.GetButtonDown("Jump") && Time.time > canFire)
        {
            canFire = Time.time + fireRate;
            var laser = Instantiate(laserPrefab, transform.position + new Vector3(1.5f, 0, 0), Quaternion.identity);
        }
        
    }
}
