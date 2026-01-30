using UnityEngine; 
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{

    public int score;
    public int scoringAmount;
    public Text scoreText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore()
    {
        score=score+scoringAmount;
        //to store and show on screen we done here type casting with .ToString
        scoreText.text = score.ToString();
        Debug.Log(score);

    }
}
