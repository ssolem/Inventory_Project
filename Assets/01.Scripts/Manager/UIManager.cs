using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] private UIMainMenu uiMainMenu;
    [SerializeField] private UIStatus uiStatus;
    [SerializeField] private UIInventory uiInventory;

    public UIMainMenu UIMainMenu { get { return uiMainMenu; } }
    public UIStatus UIStatus { get { return uiStatus; } }
    public UIInventory UIInventory { get { return uiInventory; } }

}
