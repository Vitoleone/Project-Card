using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCard : MonoBehaviour
{
  private void Start()
  {
    Physics2D.queriesHitTriggers = true;
  }

  private void OnMouseDown()
  {
    Debug.Log("Attack");
  }
}
