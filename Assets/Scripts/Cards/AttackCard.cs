using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AttackCard : MonoBehaviour
{
  private Vector3 defaultScale;
  private void Start()
  {
    Physics2D.queriesHitTriggers = true;
    defaultScale = transform.localScale;
  }

  private void OnMouseDown()
  {
    Debug.Log("Attack");
  }

  private void OnMouseEnter()
  {
    transform.DOScale(defaultScale*1.2f, 0.3f);
  }
  private void OnMouseExit()
  {
    transform.DOScale(defaultScale, 0.3f);
  }
}
