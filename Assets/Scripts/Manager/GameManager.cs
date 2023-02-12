using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
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
    }

    private void Update()
    {
        if (hand.Count <= 0)
        {
            DrawCard();
        }
    }

    public void DrawCard()
    {
        if(hand.Count <= 0)//if player has no cards on hand or on the player turn draw cards
        for (int i = 0; i < maxCardNumber; i++)
        {
            int randomNumber = Random.Range(0, copyDeck.Count-1);
            cardOnHand.GetComponent<GetScriptableCardValues>().UpdateValues(copyDeck[randomNumber]);
            GameObject newHandCard = Instantiate(cardOnHand, transform.position, quaternion.identity);
            newHandCard.transform.DOMove(new Vector3(i * 7 - 17, -6, i), 1f).OnUpdate(()=>newHandCard.SetActive(true)).SetDelay(0.75f);
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
