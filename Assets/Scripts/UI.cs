using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public AnimationController animationController;
    Level level; 
    // Start is called before the first frame update
    void Start()
    {
        animationController = GameObject.Find("AnimationController").GetComponent<AnimationController>();
        level = GameObject.Find("Level").GetComponent<Level>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UserSelected(string property)
    {
        level.UserAsksAbout(property); 
    }

    public void FallCards(Card[] cards)
    {
        animationController.FallCards(cards); 
    }
}
