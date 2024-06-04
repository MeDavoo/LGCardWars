using UnityEngine;

[CreateAssetMenu(fileName = "New Creature Card", menuName = "Card/Creature")]
public class CreatureCardData : CardData
{
    public int attack;
    public int defence;
    public int stars;
    public int cost;
}