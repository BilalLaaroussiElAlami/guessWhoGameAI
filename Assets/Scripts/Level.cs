using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    UIController uiController;

    public Card targetCard;
    Card[] cards;
    

    // Start is called before the first frame update
    void Start()
    {
        uiController  = FindObjectOfType<UIController>();
        cards = FindObjectsOfType<Card>();

       // UserAsksAbout("kind");
    }

  

    void UserAsksAbout(string property)
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

       
        uiController.FallCards(toEliminateCards); 
    }


    bool hasProperty(string property) { return targetCard.properties.Contains(property); }
    
}
