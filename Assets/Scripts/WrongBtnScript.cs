using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WrongBtnScript : MonoBehaviour
{
    public Button Btn;
    public GameObject wBtn,
                      sBtn,
                      cMsg,
                      iMsg,
                      helpBtn;
    public bool isPresent = true,
                isSwapped = false,
                isCorrect = false,
                isIncorrect = false,
                needHelp = false;

    public void Start()
    {
        PickScript.correct_btn_selected += disable_btn;
        Btn.GetComponent<Button>();
        Btn.onClick.AddListener(swap_btn_img);

        wBtn.SetActive(isPresent);
        sBtn.SetActive(isSwapped);
        cMsg.SetActive(isCorrect);
        iMsg.SetActive(isIncorrect);
        helpBtn.SetActive(needHelp);
    }

    public void swap_btn_img()
    {
        isPresent = false;
        isSwapped = true;
        isIncorrect = true;
        needHelp = true;

        wBtn.SetActive(isPresent);
        sBtn.SetActive(isSwapped);
        cMsg.SetActive(isCorrect);
        iMsg.SetActive(isIncorrect);
        helpBtn.SetActive(needHelp);
    }

    public void disable_btn(bool isEnabled)
    {
        isEnabled = false;
        Btn.interactable = isEnabled;
    }

    public void OnDestroy()
    {
        PickScript.correct_btn_selected -= disable_btn;
    }
}