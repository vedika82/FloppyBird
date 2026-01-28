using UnityEngine; 
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Runtime.CompilerServices;



public class Player : MonoBehaviour
{

    private Rigidbody2D rb;
    public float jumpForce;
    public string levelName;
    private Vector2 startPosition;
    // private SpriteRenderer sr;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
            
    //     rb.isKinematic = true;
    //         sr=GetComponent<SpriteRenderer>();
    // startPosition = rb.position;

    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetButtonDown("Jump"))
     {  //here we have taken x cause only movement in y direction
    //  rb.velocity= new Vector2(rb.velocity.x , jumpForce);
     rb.velocity= new Vector3(0,5,0);//takes 3 values x,y,z only have to move in y here
    

}    
    }

//if touched pipe then level restarts the code is below
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="Pipe")
        {
            SceneManager.LoadScene(levelName);
        }
        //we need to access the scoring pipe
        else if (collision.gameObject.tag == "Scoring")
        {
            FindObjectOfType<Scoring>().IncreaseScore();
        }
    }

        private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="Ground")
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
 