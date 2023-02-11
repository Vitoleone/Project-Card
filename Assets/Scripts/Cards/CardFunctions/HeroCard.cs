using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HeroCard : MonoBehaviour
{
    private Vector3 defaultScale;
    private GameManager gameManager;
    private void Start()
    {
        Physics2D.queriesHitTriggers = true;
        defaultScale = transform.localScale;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnMouseDown()
    {
        Debug.Log("Hero");
        gameManager.instance.hand.Remove(gameObject);
        Destroy(gameObject);
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
