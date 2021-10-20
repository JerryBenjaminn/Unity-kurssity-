using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject laserPrefab;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            var laser = Instantiate(laserPrefab, transform.position + new Vector3(1.5f, 0, 0), Quaternion.identity);
        }
    }
}
