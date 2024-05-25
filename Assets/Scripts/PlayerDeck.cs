using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<MonsterCard> deck = new List<MonsterCard>();

    public int x;
    void Start()
    {
        x = 0;

        for (int i = 0; i < 40; i++)
        {
            x = Random.RandomRange(0, 4);
            deck.Add(CardDatabase.monsterCardList[x]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
