using System.Collections.ObjectModel;
using System.Collections;
// using System.Collections.Generic;
using UnityEngine; 
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;



public class Player : MonoBehaviour
{

    private Rigidbody2D rb;
    public float jumpForce;


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
     rb.velocity= new Vector2(rb.velocity.x , jumpForce);
}    
    }
}
 