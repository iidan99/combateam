using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandCenter_Buttons : MonoBehaviour {
    public GameObject window;

    public void SettingsButton()
    {
        this.window.SetActive(true);
    }

    public void CloseWindow()
    {
        this.window.SetActive(false);
    }
}
