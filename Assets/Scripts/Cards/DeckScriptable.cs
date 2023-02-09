using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Deck",menuName = "ScriptableObject/Deck")]
public class DeckScriptable : ScriptableObject
{
  public List<CardScriptable> cards;
}
