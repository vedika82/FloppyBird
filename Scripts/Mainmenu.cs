using UnityEngine; 
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Runtime.CompilerServices;
using UnityEngine.UI;


public class Mainmenu : MonoBehaviour
{

    public Button strtbutton;
    public Button quitbutton;
    public Button settingsbutton;


    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StrtButton()
    {
        // Time.timeScale =1f;
        //to go to main menu
        SceneManager.LoadScene(1);
        
    }

    public void Quitbutton()
    {
        // Time.timeScale =1f;
        //to go to main menu
        Debug.Log("quitss");
        
    }


}
