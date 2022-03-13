using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    Card[] cards; 
    // Use this for initialization
    void Start()
    {
        cards = FindObjectsOfType<Card>();
        
    }

    void ask(string property)
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }
}
