using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class LilFella : MonoBehaviour
{
    public Button lilBtn;
    public bool isDead = false;

    public static event Action<bool> fella_is_dead = delegate { };
    void Start()
    {
        isDead = true;
        lilBtn.interactable = isDead;
    }
}
