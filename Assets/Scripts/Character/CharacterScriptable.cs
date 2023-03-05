using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character",menuName = "ScriptableObject/Character")]
public class CharacterScriptable : ScriptableObject
{

    public CharacterType character;
    public double characterLevel;
    public double currentExp;
    private double _maxExp;
    public double MaxExp
    {
        get
        {
            return _maxExp = characterLevel * 1324;
        }
        
    }

    public DeckScriptable startDeck;
    public Sprite characterImage;

    public enum  CharacterType
    {
        Necromancer,
        Samurai,
        Ranger
    }
}
