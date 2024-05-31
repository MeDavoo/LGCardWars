using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]

public class MonsterCard 
{
    public int id;
    public string cardName;

    [HideInInspector]
    public int elementId;
    public int cost;
    public string cardDescription;
    public int attack;
    public int defence;

    public Sprite monsterImage;
    public Sprite borderElementImage;

    public MonsterCard()
    {

    }

    public MonsterCard(int Id, int ElementId, string CardName, int Cost, string CardDescription, int Attack, int Defence, Sprite MonsterImg, Sprite BorderElementImage)
    {
        id = Id;
        elementId = ElementId;
        cardName = CardName;
        cost = Cost;
        cardDescription = CardDescription;
        attack = Attack;
        defence = Defence;
        monsterImage = MonsterImg;
        borderElementImage = BorderElementImage;
    }
}