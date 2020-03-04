using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class welcome : MonoBehaviour {
    public GameObject login;
    public float timer;
    bool start;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonUp(0))
        {
            start = true;
            Destroy(this.gameObject, 0.5f);
        }
        if (start)
        {
            timer += Time.deltaTime;
        }
            if (timer >= 0.5f)
            {
                this.login.SetActive(true);
            }
	}
}
