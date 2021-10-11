using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //M‰‰ritell‰‰n muuttujat pelaajan liikuttamiseen
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Pelaajan rigidbody-komponenttia kutsutaan, kun peli aloitetaan
    }

    
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical"); //M‰‰ritell‰‰n pelaajan liike y-akselilla, kun painetaan haluttua n‰pp‰int‰ 
        playerDirection = new Vector2(0, directionY).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed); //Kun pelaajalle on m‰‰ritelty liike, niin sen nopeutta voidaan s‰‰t‰‰ Unityss‰ ilman, ett‰ scripti‰ tarvitsee muuttaa
    }
}
