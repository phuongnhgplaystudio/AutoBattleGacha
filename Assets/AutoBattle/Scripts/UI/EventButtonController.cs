using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace AutoBattle
{
    public class EventButtonController : MonoBehaviour
    {
        public void OnClick()
        {
            RectTransform parentRect = transform.GetComponent<RectTransform>();
            Sequence s = DOTween.Sequence();
            s.Append(parentRect.DOScale(1.15f, .1f));
            s.Append(parentRect.DOScale(1, .2f));
            
            Debug.Log(this.gameObject.name + " on click !");
        }
    }
}
