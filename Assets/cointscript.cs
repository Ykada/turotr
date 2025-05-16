using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class cointscript : MonoBehaviour
{
    // To Do's:
    // Private Variabele voor score type int
    // Private List voor "Coins" type int
    [SerializeField] private int score;
    [SerializeField] private List<int> Coins;

    void Start()
    {
        // Loop: toon 3x een startbericht met Debug.Log in een loop

        for (int i = 0; i < 3; i++)
        {
            Debug.Log("Start");
        }

    }

    void Update()
    {


        if (score >= 50)
        {
            Debug.Log("You win");
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {




            int randomWaarde = Random.Range(10, 20);
            AddCoin(randomWaarde);

        }
    }

    // Functie om een munt toe te voegen
    void AddCoin(int coinValue)
    {

        Coins.Add(coinValue);
        score += coinValue;
        Debug.Log("Pickup coin value" + coinValue);
    }
}