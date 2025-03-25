using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    private ItemData itemData;
    private bool isEquipped = false;

    [SerializeField] private Image icon;
    [SerializeField] private Button slotButton;
    [SerializeField] private GameObject equipIcon;

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
        GameManager.Instance.Character.GetEquipData(itemData);
        if (!isEquipped)
        {
            GameManager.Instance.Character.Equip.Invoke();
            equipIcon.SetActive(!isEquipped);
        }
        else
        {
            GameManager.Instance.Character.UnEquip.Invoke();
            equipIcon.SetActive(!isEquipped);
        }

        isEquipped = !isEquipped;
    }
}
