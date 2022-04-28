using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    public Button qBtn;     // Create a new button

    void Start()
    {
        qBtn = GetComponent<Button>();          // Set the button's component to a button
        qBtn.onClick.AddListener(quit_hues);    // Give it an on-click listener
    }

    // Go here, and quit the game
    public void quit_hues()
    {
        Application.Quit();
    }
}
