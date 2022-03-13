using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{

    string fallTrigger = "Fall";  //has to be same as parameter in Animator

    Card[] cards;
    Queue<Card> queOfCards;

    float deltaBetweenFalls; //aantal mss tussen vallen van kaartjes.
    float deltaT;


    // Start is called before the first frame update
    void Start()
    {
        cards = FindObjectsOfType<Card>();
        queOfCards = new Queue<Card>();
        deltaBetweenFalls = 0.250f;
        deltaT = deltaBetweenFalls;

        Debug.Log("running");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(queOfCards.Count > 0)
        {
            deltaT -= Time.deltaTime;
            if (deltaT <= 0) {
                Debug.Log("WHOOPTY");
                deltaT = deltaBetweenFalls;
                Card toFallCard = queOfCards.Dequeue();
                FallCard(toFallCard); 

            }
        }
   
    }


    public void FallCard(Card card)
    {
        Animator animator = card.GetComponent<Animator>();
        animator.SetTrigger(fallTrigger);
    }

    public void FallCards(Card[] cards)
    {
        foreach (Card card in cards)
        {
            queOfCards.Enqueue(card);
            Debug.Log(queOfCards); 
        }

        foreach (var car in queOfCards)
        {
         //   Debug.Log(car);
        }
    }
}
