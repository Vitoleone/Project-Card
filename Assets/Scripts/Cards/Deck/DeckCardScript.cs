using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;
using Unity.VisualScripting;

public class DeckCardScript : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    private Vector3 defaultScale;
    private void Start()
    {
        defaultScale = transform.localScale;
    }
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.DOScale(defaultScale*1.2f, 0.3f);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOScale(defaultScale, 0.3f);
    }
    
}
