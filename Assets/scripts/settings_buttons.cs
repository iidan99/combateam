using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settings_buttons : MonoBehaviour {
    Userdb db;
    RectTransform pos;
    int myNumber;
    bool me;
	// Use this for initialization
	void Start () {
        pos = this.GetComponent<RectTransform>();
        db = GameObject.FindGameObjectWithTag("userinfo").GetComponent<Userdb>();
        string numb = name.Substring(name.Length - 1, 1);
        myNumber = int.Parse(numb);
        me = db.settings[myNumber];

        if (me == false)
        {
            pos.anchoredPosition = new Vector2(19 , pos.anchoredPosition.y);
        }
        else
        {
            pos.anchoredPosition = new Vector2(84, pos.anchoredPosition.y);
        }
        
	}

    void Update()
    {
        if (pos.anchoredPosition.x >= 19 && !me)
        {
            pos.anchoredPosition = new Vector2(pos.anchoredPosition.x - (Time.deltaTime * 80) , pos.anchoredPosition.y);
        }
        else if (pos.anchoredPosition.x <= 84 && me)
        {
            print(pos.anchoredPosition.x);
            pos.anchoredPosition = new Vector2(pos.anchoredPosition.x + (Time.deltaTime * 80), pos.anchoredPosition.y);
        }
    }

    public void changeStatus()
    {
        if (me)
        {
            me = false;
            db.settings[myNumber] = false;
        }
        else
        {
            me = true;
            db.settings[myNumber] = true;
        }
    }

}