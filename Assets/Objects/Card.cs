using UnityEngine;

[System.Serializable]

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public int id;
    public string cardName;
    public int attack;
    public int defense;

    public Card()
    {

    }

    public Card(int Id, string CardName, int Attack, int Defense)
    {
        id = Id;
        cardName = CardName;
        attack = Attack;
        defense = Defense;
    }
}
