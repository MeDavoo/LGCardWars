using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<MonsterCard> monsterCardList = new List<MonsterCard>();
    void Awake()
    {


        //int Id, int ElementId, int Attack, int Defence, int Cost, int Stars, string CardName, string CardDescription, Sprite MonsterImg

        monsterCardList.Add(new MonsterCard(0, 0, 6, 1, 3, 2, "Archer Dan", "FLOOP: Fires 3 explosive corn arrows at nearest targets.", Resources.Load<Sprite>("Art/Cards/MonsterArt/Pictures/0")));
        monsterCardList.Add(new MonsterCard(1, 1, 3, 2, 2, 4, "Elf Chief", "FLOOP: Runs close quarter attacks with his bow", Resources.Load<Sprite>("Art/Cards/MonsterArt/Pictures/1")));
    }
}