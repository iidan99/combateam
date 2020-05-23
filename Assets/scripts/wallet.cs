using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class wallet : MonoBehaviour {
    Userdb userInfo;
    public Text credit;
    public Text diamonds;
    // Use this for initialization
    void Start () {
        userInfo = GameObject.FindGameObjectWithTag("userinfo").GetComponent<Userdb>();
        credit.text = userInfo.credits.ToString();
        diamonds.text = userInfo.diamonds.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        if(credit.text != userInfo.credits.ToString())
        {
        credit.text = userInfo.credits.ToString();
        }

        if(diamonds.text != userInfo.diamonds.ToString())
        {
        diamonds.text = userInfo.diamonds.ToString();
        }
    }
}

