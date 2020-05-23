using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandCenter_Buttons : MonoBehaviour {
    public GameObject window;
    public GameObject tabs;

    public void SettingsButton()
    {
        this.window.SetActive(true);
        this.tabs.GetComponent<RectTransform>().SetAsLastSibling();
    }

    public void CloseWindow()
    {
        this.window.SetActive(false);
    }
}
