using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Userdb : MonoBehaviour {
    LoginHandler atuh;
    public string userName;
    public int level;
    public string idToken;

    //אימייל משתמש
    public string userEmail;
    //רמת משתמש
    public int userLevel;
    //EXP משתמש
    public int userEXP;
    //Max Exp to the next Level
    public int maxEXP;

    //כמות כלפים
    public int userCards;
    //Music on / off / Local Save 
    public bool music;
    //Sound Effect on / off / Local Save 
    public bool sound;
    //הדרכה
    public bool tutorials;
    //credits
    public int credits;
    //diamonds
    public int dimonds;


    // Use this for initialization
    void Start () {
        atuh = GameObject.FindGameObjectWithTag("FireBase").GetComponent<LoginHandler>();

        Application.DontDestroyOnLoad(this);
        Screen.sleepTimeout = (int)SleepTimeout.NeverSleep;
        idToken = PlayerPrefs.GetString("token");
        maxEXP = 1000;
        userName = "Idan";
        userLevel = 1;
      
    }
	
	// Update is called once per frame
	void Update () {
        
        
	}
}
