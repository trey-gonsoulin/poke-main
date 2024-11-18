using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class DisplayCard : MonoBehaviour
{
    // public List<Card> displayCard = new List<Card>();
    public Card card;

    public int displayId;

    public int id;
    public string cardName;
    public int attack;
    public int defense;

    public TMP_Text nameText;
    public TMP_Text attackText;
    public TMP_Text defenseText;
    // public Sprite cardImage;


    // Update is called once per frame
    void Update()
    {
        id = card.id;
        // cardName = card.cardName;
        // attack = card.attack;
        // defense = card.defense;

        nameText.text = card.cardName.ToString();
        attackText.text = card.attack.ToString();
        defenseText.text = card.defense.ToString();
    }
}
