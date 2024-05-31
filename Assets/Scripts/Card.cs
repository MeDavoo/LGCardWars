using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Card : MonoBehaviour
{
    private List<MonsterCard> thisCard = new List<MonsterCard>();
    public int CardId;

    private int id;
    private int elementId;
    public string cardName;
    private int cost;
    private string cardDescription;
    private int attack;
    private int defence;
    private int stars;

    private TMP_Text nameText;
    private TMP_Text costText;
    private TMP_Text cardDescriptionText;
    private TMP_Text attackText;
    private TMP_Text defenceText;

    private Sprite monsterImage;
    private Image monsterImgObj;

    private Sprite borderElementImage;
    private Image borderElementImgObj;

    private GameObject cardContainer,bgsDirectory,starsSliderObj;




    public bool selected;
    public int handPosition, deckPosition, fieldPosition;







    void Start()
    {
        thisCard.Add(CardDatabase.monsterCardList[CardId]);
        id = -1;

        cardContainer = this.gameObject.transform.GetChild(0).gameObject;
        bgsDirectory = cardContainer.transform.GetChild(1).gameObject;
        nameText = bgsDirectory.transform.GetChild(6).GetComponent<TMP_Text>();
        costText = bgsDirectory.transform.GetChild(5).GetComponent<TMP_Text>();
        cardDescriptionText = bgsDirectory.transform.GetChild(9).GetComponent<TMP_Text>();
        attackText = bgsDirectory.transform.GetChild(8).GetComponent<TMP_Text>();
        defenceText = bgsDirectory.transform.GetChild(7).GetComponent<TMP_Text>();
        monsterImage = Resources.Load<Sprite>("Art/Cards/MonsterArt/Pictures/0");
        monsterImgObj = bgsDirectory.transform.GetChild(1).GetComponent<Image>();
        borderElementImage = Resources.Load<Sprite>("Art/Cards/MonsterArt/Elements/0");
        borderElementImgObj = bgsDirectory.transform.GetChild(3).GetComponent<Image>();
        starsSliderObj = bgsDirectory.transform.GetChild(2).GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (id != CardId)
        {
            thisCard[0] = CardDatabase.monsterCardList[CardId];

            id = thisCard[0].id;
            elementId = thisCard[0].elementId;
            cardName = thisCard[0].cardName;
            cost = thisCard[0].cost;
            cardDescription = thisCard[0].cardDescription;
            attack = thisCard[0].attack;
            defence = thisCard[0].defence;
            stars = thisCard[0].stars;


            if (elementId == 0)
            {
                borderElementImage = Resources.Load<Sprite>("Art/Cards/MonsterArt/Elements/0");
            }
            else if (elementId == 1)
            {
                borderElementImage = Resources.Load<Sprite>("Art/Cards/MonsterArt/Elements/1");
            }
            else if (elementId == 2)
            {
                borderElementImage = Resources.Load<Sprite>("Art/Cards/MonsterArt/Elements/2");
            }
            else if (elementId == 3)
            {
                borderElementImage = Resources.Load<Sprite>("Art/Cards/MonsterArt/Elements/3");
            }

            if (stars == 1)
            {
                starsSliderObj.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 12);
            }
            else if (stars == 2)
            {
                starsSliderObj.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 22);
            }
            else if (stars == 3)
            {
                starsSliderObj.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 31);
            }
            else if (stars == 4)
            {
                starsSliderObj.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 41);
            }
            else if (stars == 5)
            {
                starsSliderObj.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 50);
            }


            monsterImage = thisCard[0].monsterImage;

            nameText.text = "" + cardName;
            costText.text = "" + cost;
            cardDescriptionText.text = "" + cardDescription;
            attackText.text = "" + attack;
            defenceText.text = "" + defence;

            monsterImgObj.sprite = monsterImage;
            borderElementImgObj.sprite = borderElementImage;
        }



        if(!selected) { MoveToPosition(); }

        if(Input.GetMouseButtonUp(0)) { selected = false; }

    }

    void MoveToPosition()
    {
        Vector3 toPosition = new Vector3(0, 0, 0);
        Quaternion toRotation = Quaternion.Euler(0, 0, 0);
        Vector3 toScale = new Vector3(1, 1, 1);


        if (deckPosition > -1)
        {
            toPosition = new Vector3(1.5f, -1.5f, 0);
            toRotation = Quaternion.Euler(0, 180, 0);
            toScale = new Vector3(0.25f, 0.25f, 0.25f);
        }
        else if (handPosition > -1)
        {
            toPosition = new Vector3(0f, -3.0f, 0);
            toScale = new Vector3(0.3f, 0.3f, 0.3f);
        }
        else if (fieldPosition > -1)
        {
            toPosition = new Vector3(0f, 0f, 0);
            toScale = new Vector3(0.25f, 0.25f, 0.25f);
        }

        if (transform.position != toPosition)
        {
            transform.position = Vector3.Lerp(transform.position, toPosition, Time.deltaTime * 3.0f);
        }

        if(transform.rotation != toRotation)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, Time.deltaTime * 10.0f);
        }

        if(transform.localScale != toScale)
        {
            transform.position = Vector3.Lerp(transform.localScale, toScale, Time.deltaTime * 3.0f);
        }
    }

    void OnMouseDrag()
    {
        selected = true;
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion toRotation = Quaternion.Euler((mousePosition.y - transform.position.y) * 90, -(mousePosition.x - transform.position.x) * 90, 0);

        mousePosition.z = 0;

        transform.position = Vector3.Lerp(transform.position, mousePosition, Time.deltaTime * 15.0f);
        transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, Time.deltaTime * 15.0f);
    }
}
