using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class blink : MonoBehaviour {
    public Image image;
    public float maxtimer, waittimer, timer2, timer;
    public bool timertrue = true, isactive = false;

    // Use this for initialization
    void Start () {
        image = GetComponent<Image>();
    }
	
	// Update is called once per frame
	void Update () {
            Color c = image.color;
            if (timertrue == true)
            {
                timer2 += Time.deltaTime;
            }
            if (timer2 > maxtimer)
            {
                timertrue = false;
            }
            if (timertrue == false)
                timer2 -= Time.deltaTime;

            if (timer2 < waittimer)
                timertrue = true;

            c.a = timer2;
            image.color = c;
        }
}
