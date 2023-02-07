using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "Card",menuName = "ScriptableObject/Card")]
public class CardScriptable : ScriptableObject
{
    public string cardName;
    public double cardMana;
    public string cardDescription;
    public CardType cardType;
    public Sprite cardImage;

    public enum CardType
    {
        Attack,
        Defence,
        Buff,
        Hero
    }
    
}
