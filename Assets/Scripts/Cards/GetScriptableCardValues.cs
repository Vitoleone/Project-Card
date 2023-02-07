using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GetScriptableCardValues : MonoBehaviour
{
    public SpriteRenderer sprite;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI cardName;
    public TextMeshProUGUI manaText;
    public TextMeshProUGUI cardType;
    public CardScriptable cardScriptable;
    void Start()
    {
        sprite.sprite = cardScriptable.cardImage;
        descriptionText.text = cardScriptable.cardDescription;
        cardName.text = cardScriptable.cardName;
        cardType.text = cardScriptable.cardType.ToString();
        manaText.text = cardScriptable.cardMana.ToString();
        
    }
    public enum CardType
    {
        Attack,
        Defence,
        Buff,
        Hero
    }
}
