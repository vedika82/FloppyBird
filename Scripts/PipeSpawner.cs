using System.Numerics;
// using System.Threading.Tasks.Dataflow;
using UnityEngine;
// using UnityEngine.Quaternion;
using System.Collections.Generic;

public class PipeSpawner : MonoBehaviour
{

    public GameObject pipePrefab;
    public Transform Spawnpoint;
    public  float spawnInterval=3f;

    private float timer;

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
        {//where do we have to apply this spawn on 
            Instantiate(pipePrefab, Spawnpoint.position , UnityEngine.Quaternion.identity);
            timer=0f;
        }
    }
}
