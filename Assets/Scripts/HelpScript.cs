using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpScript : MonoBehaviour
{
    public Button Btn;
    public GameObject HelpMsg;
    public bool isHelping = false;

    public void Start()
    {
        Btn.GetComponent<Button>();
        Btn.onClick.AddListener(show_hide_help_msg);

        HelpMsg.SetActive(isHelping);
    }

    public void show_hide_help_msg()
    {
        isHelping ^= true;
        HelpMsg.SetActive(isHelping);
    }
}
