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
    public int stars;

    public Sprite monsterImage;
    public Sprite borderElementImage;

    public MonsterCard()
    {

    }

    public MonsterCard(int Id, int ElementId, int Attack, int Defence, int Cost, int Stars, string CardName, string CardDescription, Sprite MonsterImg)
    {
        id = Id;
        elementId = ElementId;
        attack = Attack;
        defence = Defence;
        cost = Cost;
        stars = Stars;
        cardName = CardName;
        cardDescription = CardDescription;
        monsterImage = MonsterImg;
    }
}