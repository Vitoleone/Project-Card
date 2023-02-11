using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public GameManager instance;
    public DeckScriptable deck;
    private List<CardScriptable> copyDeck;
    public List<GameObject> hand;
    public GameObject cardOnHand;
    public int maxCardNumber = 5;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        copyDeck = deck.cards;
        DrawCard();
    }

    public void DrawCard()
    {
        
        for (int i = 0; i < maxCardNumber; i++)
        {
            int randomNumber = Random.Range(0, copyDeck.Count-1);
            cardOnHand.GetComponent<GetScriptableCardValues>().UpdateValues(copyDeck[randomNumber]);
            GameObject newHandCard = Instantiate(cardOnHand, new Vector3(i * 7 - 17, -6, i), quaternion.identity);
            AddCardFunction(newHandCard);
            hand.Add(newHandCard);
            
        }
    }

    public void AddCardFunction(GameObject card)
    {
        switch (card.GetComponent<GetScriptableCardValues>().cardName.text)
        {
            case "Attack Card":
                card.AddComponent<AttackCard>();
                break;
            case "Buff Card":
                card.AddComponent<BuffCard>();
                break;
            case "Defence Card":
                card.AddComponent<DefenceCard>();
                break;
            case "Hero Card":
                card.AddComponent<HeroCard>();
                break;
            default:
                break;

        }
    }
}
