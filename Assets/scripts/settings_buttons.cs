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
            pos.anchoredPosition = new Vector2(50 , pos.anchoredPosition.y);
        }
        else
        {
            pos.anchoredPosition = new Vector2(123.6f, pos.anchoredPosition.y);
        }
        
	}

    void Update()
    {
        if (pos.anchoredPosition.x >= 50 && !me)
        {
            pos.anchoredPosition = new Vector2(pos.anchoredPosition.x - (5) , pos.anchoredPosition.y);
        }
        else if (pos.anchoredPosition.x <= 123.6f && me)
        {
            pos.anchoredPosition = new Vector2(pos.anchoredPosition.x + (5), pos.anchoredPosition.y);
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