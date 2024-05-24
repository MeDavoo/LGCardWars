using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<MonsterCard> monsterCardList = new List<MonsterCard>();
    void Awake()
    {
        monsterCardList.Add(new MonsterCard(0, 0, "None", 0, "Description", 0, 0, Resources.Load<Sprite>("Art/Cards/MonsterArt/Pictures/0"), Resources.Load<Sprite>("Art/Cards/MonsterArt/Elements/0")));
        monsterCardList.Add(new MonsterCard(1, 0, "Test1", 1, "Description1", 1, 2, Resources.Load<Sprite>("Art/Cards/MonsterArt/Pictures/1"), Resources.Load<Sprite>("Art/Cards/MonsterArt/Elements/1")));
        monsterCardList.Add(new MonsterCard(2, 0, "Test2", 1, "Description2", 5, 8, Resources.Load<Sprite>("Art/Cards/MonsterArt/Pictures/2"), Resources.Load<Sprite>("Art/Cards/MonsterArt/Elements/2")));
        monsterCardList.Add(new MonsterCard(3, 0, "Test3", 2, "Description3", 3, 1, Resources.Load<Sprite>("Art/Cards/MonsterArt/Pictures/3"), Resources.Load<Sprite>("Art/Cards/MonsterArt/Elements/3")));
        monsterCardList.Add(new MonsterCard(4, 0, "Test4", 3, "Description3", 7, 4, Resources.Load<Sprite>("Art/Cards/MonsterArt/Pictures/4"), Resources.Load<Sprite>("Art/Cards/MonsterArt/Elements/4")));
    }
}