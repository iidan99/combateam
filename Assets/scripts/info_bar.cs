using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class info_bar : MonoBehaviour {
    Userdb data;
        public Text Exp_Value;

	// Use this for initialization
	void Start () {
        data = GameObject.FindGameObjectWithTag("userinfo").GetComponent<Userdb>();
        this.Exp_Value = GetComponent<Text>();

        if (gameObject.name == "Name")
        {
            this.Exp_Value.text = data.userName;
        }
        else if (gameObject.name == "Level")
        {
            this.Exp_Value.text = "Level: " + data.userLevel.ToString();
        }
        else if (gameObject.name == "Exp Fill Bar")
        {
            this.Exp_Value.text = data.userEXP + "/" + data.maxEXP.ToString();
            GameObject.Find("Level Bar Fill").GetComponent<Image>().fillAmount = (float)data.userEXP / (float)data.maxEXP;
        }
    }
	
	// Update is called once per frame
	void Update () {
      
    }
}
