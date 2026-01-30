using UnityEngine; 
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
public class Pipes : MonoBehaviour
{

    public float moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//done to move the pipes to the left 
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
       
        //to destroy the pipes out of frame
        if (transform.position.x<-15)
        {
            Destroy(gameObject);
        }
    }
}
