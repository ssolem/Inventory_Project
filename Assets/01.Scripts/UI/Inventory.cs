using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<ItemData> items;
    [SerializeField] private UISlot slotPrefab;
    [SerializeField] private RectTransform slotParent;

    public List<ItemData> Items { get { return items; } }

    public List<UISlot> slots = new List<UISlot>();

    void Start()
    {
        Init();
    }

    void Init()
    {
        for (int i = 0; i < 40; i++)
        {
            UISlot newSlot = Instantiate(slotPrefab, slotParent);
            slots.Add(newSlot);
        }

        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] != null)
            {
                slots[i].GetItemData(items[i]);
            }
        }
    }
}
