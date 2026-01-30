using UnityEngine; 
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Runtime.CompilerServices;
// using Scoring;
using UnityEngine.UI;



public class Player : MonoBehaviour
{

    private Rigidbody2D rb;
    public float jumpForce;
    public string levelName;
    private Vector2 startPosition;
    // private SpriteRenderer sr;

    //scoring script here ctrl v
    public int score;
    public int scoringAmount;
    public Text scoreText;

    public GameObject gameover;
    public Text gameovertext;

    private int restartbutton;

    public Button menuButton;
    public Button restartButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
            
    //     rb.isKinematic = true;
    //         sr=GetComponent<SpriteRenderer>();
    // startPosition = rb.position;

    //dont want gameover screen first
        gameover.SetActive(false);
        menuButton.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetButtonDown("Jump"))
        {  //here we have taken x cause only movement in y direction
            //  rb.velocity= new Vector2(rb.velocity.x , jumpForce);
        rb.linearVelocity= new Vector3(0,5,0);//takes 3 values x,y,z only have to move in y here
        }    
    }

//if touched pipe then level restarts the code is below
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="Pipe")
        {
            // SceneManager.LoadScene(levelName);
            GameOverMechanics();
        }
        //we need to access the scoring pipe
        else if (collision.gameObject.tag == "Scoring")
        {   //to call fxn from a differnt script
            // FindObjectOfType<Scoring>().IncreasScore();
            IncreaseScore();
        }
    }

        private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="Ground")
        {
            // SceneManager.LoadScene(levelName);
            GameOverMechanics();

        }
    }

     public void IncreaseScore()
    {
        score=score+scoringAmount;
        //to store and show on screen we done here type casting with .ToString
        scoreText.text = score.ToString();
        Debug.Log(score);

    
    }

        public void GameOverMechanics()
    {
        gameover.SetActive(true);
        
        gameovertext.text ="SCORE:" + score;

        //time to freez
        Time.timeScale =0f;

        restartButton.gameObject.SetActive(true);
        menuButton.gameObject.SetActive(true);


          
     }


     public void RestartLevel()
    {   //to make time normal 
        Time.timeScale =1f;
        //to restart level
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }

      public void LoadMenu()
    {
        Time.timeScale =1f;
        //to go to main menu
        SceneManager.LoadScene(0);
        
    }
}
         