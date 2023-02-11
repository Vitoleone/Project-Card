using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DeckController : MonoBehaviour
{
    public DeckScriptable deck;
    public GameObject cardInDeck;
    public GameObject cardsPanel;
    public GameObject deckPanel;

    public void OpenDeck()
    {
        if (deckPanel.gameObject.active)
        {
            deckPanel.SetActive(false);
            foreach(Transform child in cardsPanel.transform)
            {
                Destroy(child.gameObject);
            }
        }
        else
        {
            deckPanel.SetActive(true);
            foreach (var card in deck.cards)
            {
                GameObject newCardInDeck = Instantiate(cardInDeck, cardsPanel.transform.position, quaternion.identity);
                newCardInDeck.transform.parent = cardsPanel.transform;
                newCardInDeck.transform.localScale = Vector3.one;
                newCardInDeck.GetComponent<GetScriptableCardValues>().UpdateValues(card);
                cardInDeck.GetComponent<GetScriptableCardValues>().cardScriptable = card;
            }   
        }
        
    }

    public void CloseDeck()
    {
        deckPanel.SetActive(false);
        foreach(Transform child in cardsPanel.transform)
        {
            Destroy(child.gameObject);
        }
    }
}
