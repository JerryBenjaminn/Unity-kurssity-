using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject); // Luodaan tagiin pohjautuva OnTriggerEnter2D- metodi, joka tarkistaa kun meteori osuu collideriin, niin se tuhoutuu
        }
    }
}
