using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(0, "Missingno", -1, -1));
        cardList.Add(new Card(1, "Bulbasaur", 1, 2));
        cardList.Add(new Card(2, "Ivysaur", 2, 4));
        cardList.Add(new Card(3, "Venusaur", 4, 8));
        cardList.Add(new Card(4, "Charmander", 2, 1));
    }
}
