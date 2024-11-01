using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.T

public class UiOptions : MonoBehaviour
{
    public int optionIndex;
    public string[] objectInfoText;
    public GameObject[] objects;
    public GameObject _info;
    public Toggle toggleInfo;
    public Dropdown dropdown;
    //public tmpro

    public void selectOption()
    {
        
    }
    public void infoToggle()
    {
        if (toggleInfo.isOn)
        {
            _info.SetActive(true);
        }
        else
        {
            _info.SetActive(false);
        }
    }
}
