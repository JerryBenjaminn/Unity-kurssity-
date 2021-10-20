using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") == null) // Metodi tarkastaa, jos pelaajan hahmo on tuhoutunut, niin game over- ruutu tulee n‰kyviin.
        {
            gameOverPanel.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Restart metodi- joka tuo pelin aloituksen esiin (k‰ynnist‰‰ uuden session)
    }
}
