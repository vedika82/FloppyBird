using UnityEngine; 
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;


public class PipeSpawner : MonoBehaviour
{

    public GameObject pipePrefab;
    public Transform Spawnpoint;
    public  float spawnInterval=3f;

    private float timer;

    //min and max Y position where pipes can be spawned
    public float minYposition = -2f;
    public float maxYposition = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//to calculate time means taking timer and increasing slowly
        timer+= Time.deltaTime;

    //timer for after every 2 sc the pipes are spawned 
        if (timer>= spawnInterval)
{
            //generate random numbers between min and max
            float randomYposition = Random.Range(minYposition,maxYposition);
            //have to spawn pipes between those random no
            Vector3 spawnPosition = new Vector3 (Spawnpoint.position.x ,  randomYposition,Spawnpoint.position.z);
             //where do we have to apply this spawn on 
            Instantiate(pipePrefab, spawnPosition , Quaternion.identity);
            timer=0f;
        }
    }
}
