using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public List<CreatureCardData> monsterCards;
    public List<BuildingCardData> buildingCards;
    public List<FieldCardData> fieldCards;

    public static List<CardData> allCards = new List<CardData>();

    void Awake()
    {
        // Add all cards to the static list
        allCards.AddRange(monsterCards);
        allCards.AddRange(buildingCards);
        allCards.AddRange(fieldCards);
    }
}