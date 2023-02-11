using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GetScriptableCardValues : MonoBehaviour
{
    public Image sprite;
    public Image typeTemplate;
    public Sprite attackTemplate;
    public Sprite buffTemplate;
    public Sprite deffenceTemplate;
    public Sprite heroTemplate;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI cardName;
    public TextMeshProUGUI manaText;


    public CardScriptable cardScriptable;
    

    public void SetValues()
    {
        sprite.sprite = cardScriptable.cardImage;
        descriptionText.text = cardScriptable.cardDescription;
        cardName.text = cardScriptable.cardName;
        manaText.text = cardScriptable.cardMana.ToString();
        switch (cardScriptable.cardType)
        {
            case CardScriptable.CardType.Attack:
                typeTemplate.sprite = attackTemplate;
                break;
            case CardScriptable.CardType.Buff:
                typeTemplate.sprite = buffTemplate;
                break;
            case CardScriptable.CardType.Defence:
                typeTemplate.sprite = deffenceTemplate;
                break;
            case CardScriptable.CardType.Hero:
                typeTemplate.sprite = heroTemplate;
                break;
            
        }
    }
    public void UpdateValues(CardScriptable cardScriptable)
    {
        sprite.sprite = cardScriptable.cardImage;
        descriptionText.text = cardScriptable.cardDescription;
        cardName.text = cardScriptable.cardName;
        manaText.text = cardScriptable.cardMana.ToString();
        switch (cardScriptable.cardType)
        {
            case CardScriptable.CardType.Attack:
                typeTemplate.sprite = attackTemplate;
                break;
            case CardScriptable.CardType.Buff:
                typeTemplate.sprite = buffTemplate;
                break;
            case CardScriptable.CardType.Defence:
                typeTemplate.sprite = deffenceTemplate;
                break;
            case CardScriptable.CardType.Hero:
                typeTemplate.sprite = heroTemplate;
                break;
            
        }
    }
    public enum CardType
    {
        Attack,
        Defence,
        Buff,
        Hero
    }
}
