using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private float score;

    // Update is called once per frame
    void Update() //Tämä metodi tarkastaa, että niin kauan kun pelaajan hahmo on elossa, saa pisteitä.
    {
        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
        }
    }
}
