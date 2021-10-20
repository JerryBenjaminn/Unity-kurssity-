using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject); // Luodaan tagiin pohjautuva OnTriggerEnter2D- metodi, joka tarkistaa kun meteori osuu collideriin, niin se tuhoutuu. Tässä tapauksessa collideriin peliruudun ulkopuolella
            
        }
        else if(collision.tag == "Player") //Tarkastetaan, jos pelaaja törmää toisen objektin kanssa, niin se tuhoutuu.
        {
            Destroy(player.gameObject);
        }
    }
}
