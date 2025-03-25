using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    private ItemData itemData;

    [SerializeField] private Image icon;
    [SerializeField] private Button slotButton;

    private void Start()
    {
        slotButton.onClick.AddListener(OnClickSlotButton);
    }

    public void GetItemData(ItemData data)
    {
        itemData = data;
        SetSlot();
    }

    void SetSlot()
    {
        icon.sprite = itemData.Icon;       
    }

    public void ClearSlot()
    {
        icon.sprite = null;
        itemData = null;
    }

    void OnClickSlotButton()
    {

    }
}
