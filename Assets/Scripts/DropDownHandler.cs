using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownHandler : MonoBehaviour
{


    public UI ui;
  
    // Start is called before the first frame update
    void Start()
    {
        GameObject uigameObject =  GameObject.Find("UI");
        ui = uigameObject.GetComponent<UI>();

        Dropdown propertyDropDown = this.gameObject.GetComponent<Dropdown>();
        propertyDropDown.onValueChanged.AddListener(delegate {
            DropdownValueChanged(propertyDropDown);
        });
        
       
    }

  

    //wanneer de gebruiker een propery heeft gekozen
    void DropdownValueChanged(Dropdown dropdown)
    {
        string selectedProperty = dropdown.captionText.text;
        int option = dropdown.value;
        dropdown.options.RemoveAt(option); 
        ui.UserSelected(selectedProperty); 

    }





}
