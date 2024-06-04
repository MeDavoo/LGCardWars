using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public CardData cardData;

    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text costText;
    [SerializeField] private TMP_Text cardDescriptionText;
    [SerializeField] private TMP_Text attackText;
    [SerializeField] private TMP_Text defenceText;
    [SerializeField] private TMP_Text timerText;

    [SerializeField] private Image cardImgObj;
    [SerializeField] private Image borderElementImgObj;
    [SerializeField] private Image costImage;
    [SerializeField] private Image turnTimerImage;

    [SerializeField] private GameObject starsSliderObj;

    void Start()
    {
        UpdateCardUI();
    }

    void UpdateCardUI()
    {
        if (cardData == null) return;

        nameText.text = cardData.cardName;
        cardDescriptionText.text = cardData.cardDescription;
        cardImgObj.sprite = cardData.cardImage;
        borderElementImgObj.sprite = cardData.borderElementImage;

        // Clear specific fields initially
        attackText.text = "";
        defenceText.text = "";
        timerText.text = "";
        costImage.gameObject.SetActive(false);
        turnTimerImage.gameObject.SetActive(false);

        if (cardData is CreatureCardData creatureCard)
        {
            UpdateMonsterCardUI(creatureCard);
        }
        else if (cardData is BuildingCardData buildingCard)
        {
            UpdateBuildingCardUI(buildingCard);
        }
        else if (cardData is FieldCardData fieldCard)
        {
            UpdateFieldCardUI(fieldCard);
        }
    }

    void UpdateMonsterCardUI(CreatureCardData creatureCard)
    {
        attackText.text = creatureCard.attack.ToString();
        defenceText.text = creatureCard.defence.ToString();
        costText.text = creatureCard.cost.ToString();
        costImage.gameObject.SetActive(true);
        SetStars(creatureCard.stars);
    }

    void UpdateBuildingCardUI(BuildingCardData buildingCard)
    {
        costText.text = buildingCard.cost.ToString();
        costImage.gameObject.SetActive(true);
        SetStars(buildingCard.stars);
    }

    void UpdateFieldCardUI(FieldCardData fieldCard)
    {
        timerText.text = "" + fieldCard.turnTimer;
        turnTimerImage.gameObject.SetActive(true);
        SetStars(fieldCard.stars);
    }

    void SetStars(int stars)
    {
        float starsWidth = 0;

        switch (stars)
        {
            case 1:
                starsWidth = 11;
                break;
            case 2:
                starsWidth = 22;
                break;
            case 3:
                starsWidth = 33;
                break;
            case 4:
                starsWidth = 45;
                break;
            case 5:
                starsWidth = 56;
                break;
            default:
                starsWidth = 0;
                break;
        }

        starsSliderObj.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, starsWidth);
    }
}