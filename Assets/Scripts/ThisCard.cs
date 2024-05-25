using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ThisCard : MonoBehaviour
{
    private List<MonsterCard> thisCard = new List<MonsterCard>();
    public int thisId;

    public int id;
    public int elementId;
    public string cardName;
    public int cost;
    public string cardDescription;
    public int attack;
    public int defence;

    public TMP_Text nameText;
    public TMP_Text costText;
    public TMP_Text cardDescriptionText;
    public TMP_Text attackText;
    public TMP_Text defenceText;

    public Sprite monsterImage;
    public Image monsterImgObj;

    public Sprite borderElementImage;
    public Image borderElementImgObj;

    void Start()
    {
        thisCard.Add(CardDatabase.monsterCardList[thisId]);
    }

    // Update is called once per frame
    void Update()
    {
        if (id != thisId)
        {
            thisCard[0] = CardDatabase.monsterCardList[thisId];

            id = thisCard[0].id;
            cardName = thisCard[0].cardName;
            cost = thisCard[0].cost;
            cardDescription = thisCard[0].cardDescription;
            attack = thisCard[0].attack;
            defence = thisCard[0].defence;

            monsterImage = thisCard[0].monsterImage;
            borderElementImage = thisCard[0].borderElementImage;

            nameText.text = "" + cardName;
            costText.text = "" + cost;
            cardDescriptionText.text = "" + cardDescription;
            attackText.text = "" + attack;
            defenceText.text = "" + defence;

            monsterImgObj.sprite = monsterImage;
            borderElementImgObj.sprite = borderElementImage;
        }

    }
}
