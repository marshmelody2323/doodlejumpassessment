using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int ScoreValue => scoreValue;
    public string NameInput;

    private int scoreValue = 0;
    public Text scoreText;
     
    void Start()
    {
        // scoreText = GetComponent<Text>();
        scoreText.text = "Score: " + scoreValue;
    }

    private void Update()
    {
        scoreText.text = "Score: " + scoreValue;

        float height = transform.position.y;
        if(scoreValue < height)
        {
            scoreValue = (int)height;
        }
    }


    //void OnCollisionEnter2D(Collision2D other)
    //{
    //    if (other.gameObject.tag == "Platform")
    //    {
    //        scoreValue += 10;
    //    }
    //}
}
