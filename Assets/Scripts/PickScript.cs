using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PickScript : MonoBehaviour
{
    public Button Btn;
    public GameObject uImg,
                      cImg,
                      cMsg,
                      iMsg,
                      contBtn;
    public bool isUncolored = true,
                isColored = false,
                isCorrect = false,
                isIncorrect = false;

    public static event Action<bool> correct_btn_selected = delegate { };

    public void Start()
    {
        Btn.GetComponent<Button>();
        Btn.onClick.AddListener(swap_apple_img);

        uImg.SetActive(isUncolored);
        cImg.SetActive(isColored);

        cMsg.SetActive(isCorrect);
        iMsg.SetActive(isIncorrect);
        contBtn.SetActive(isCorrect);
    }

    public void swap_apple_img()
    {
        isUncolored = false;
        isColored = true;
        isCorrect = true;
        isIncorrect = false;

        uImg.SetActive(isUncolored);
        cImg.SetActive(isColored);

        iMsg.SetActive(isIncorrect);
        cMsg.SetActive(isCorrect);
        contBtn.SetActive(isCorrect);

        correct_btn_selected(isCorrect);
    }
}