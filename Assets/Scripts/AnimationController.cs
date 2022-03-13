using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
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
    
    }

    // Update is called once per frame
    void Update()
    {
        float timeSinceLastCall = Time.deltaTime;
        FallCardsUpdate(timeSinceLastCall); 

    }


    private void FallCardsUpdate(float timeSincelastCall)
    {
        if (queOfCards.Count > 0)
        {
            deltaT -= timeSincelastCall; 
            if (deltaT <= 0)
            {
                deltaT = deltaBetweenFalls;
                Card toFallCard = queOfCards.Dequeue();
                FallCard(toFallCard);

            }
        }
    }

    private void FallCard(Card card)
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

    }

   

}
