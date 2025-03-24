using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class UIPopUp : MonoBehaviour
{
    protected private RectTransform rectTransform;
    protected private Vector3 defaultSize;

    protected virtual void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        defaultSize = rectTransform.localScale;
        Init();
    }

    protected virtual void Init()
    {
        rectTransform.localScale = new Vector3(0, defaultSize.y, 1);
    }

    protected virtual void OpenUI()
    {
        rectTransform.DOScale(defaultSize, 1f).SetEase(Ease.OutCirc);
    }

    protected virtual void CloseUI()
    {
        rectTransform.DOScale(new Vector3(0, defaultSize.y, 1), 1f).SetEase(Ease.InCirc);
    }
}
