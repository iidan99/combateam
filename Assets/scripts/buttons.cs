using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{
    LoginHandler atuh;
    public string idToken;

    private void Start()
    {
        idToken = PlayerPrefs.GetString("token");
        atuh = GameObject.FindGameObjectWithTag("FireBase").GetComponent<LoginHandler>();
    }


    public void Login()
    {
      //print(PlayerPrefs.GetString("token"));
       // atuh.TokenSign(PlayerPrefs.GetString("token"));
      atuh.Login();
    }

    public void Signin()
    {
        atuh.CreateUserAsync();
    }
}
