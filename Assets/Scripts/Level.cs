using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    UI ui ;

    public Card targetCard;
    Card[] cards;
    

    // Start is called before the first frame update
    void Start()
    {
        ui  = FindObjectOfType<UI>();
        cards = FindObjectsOfType<Card>();

       // UserAsksAbout("kind");
    }

  

    public void UserAsksAbout(string property)
    {
        bool answer = hasProperty(property);

        //pak alle kaarten waarvoor property wel/niet in zijn properties staan 
        Card[] toEliminateCards =
             Array.FindAll(cards,
             c =>
             {
                 if (answer) return !c.properties.Contains(property);  else return c.properties.Contains(property);
     
             });

        /*take answer and toEliminate cards and do decision tree whatever stuff.
         ---
        */

       
        ui.FallCards(toEliminateCards); 
    }


    bool hasProperty(string property) { return targetCard.properties.Contains(property); }
    
}
