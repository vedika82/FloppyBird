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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
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


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == "Pipe")
        {
            Scene.Mananger.LoadScene(levelName);
        }
    }
}
 