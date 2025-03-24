using System;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : UIPopUp
{
    [SerializeField] private Button backButton;

    public Action inventoryBack;

    void Start()
    {
        base.Start();

        backButton.onClick.AddListener(OnClickBackButton);
        UIManager.Instance.UIMainMenu.InventoryOpen += OpenUI;
        inventoryBack += CloseUI;
    }

    private void OnClickBackButton()
    {
        inventoryBack.Invoke();
    }
}
