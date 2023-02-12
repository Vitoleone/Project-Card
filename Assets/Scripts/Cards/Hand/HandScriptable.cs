using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Hand",menuName = "ScriptableObject/Hand")]
public class HandScriptable : ScriptableObject
{
  public List<GameObject> cardsOnHand;
}
