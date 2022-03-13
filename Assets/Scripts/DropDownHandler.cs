using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dropdown propertyDropDown =  GetComponent<Dropdown>();
        propertyDropDown.onValueChanged.AddListener(delegate {
            DropdownValueChanged(propertyDropDown);
        });
       
    }

    //wanneer de gebruiker een propery heeft gekozen
    void DropdownValueChanged(Dropdown dropdown)
    {

        Debug.Log("User Selected");
        Debug.Log(dropdown.captionText.text);
    }





}
