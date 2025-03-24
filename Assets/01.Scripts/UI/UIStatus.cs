using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : UIPopUp
{
    [SerializeField] private TextMeshProUGUI attackTxt;
    [SerializeField] private TextMeshProUGUI defenseTxt;
    [SerializeField] private TextMeshProUGUI healthTxt;
    [SerializeField] private TextMeshProUGUI critTxt;
    [SerializeField] private Button backButton;

    public Action statusBack;

    protected override void Start()
    {
        base.Start();

        SetStatus();
        backButton.onClick.AddListener(OnClickBackButton);
        UIManager.Instance.UIMainMenu.StatusOpen += OpenUI;
        statusBack += CloseUI;
    }

    protected override void OpenUI()
    {
        SetStatus();
        base.OpenUI();
    }

    private void SetStatus()
    {
        attackTxt.text = GameManager.Instance.Character.Attack.ToString();
        defenseTxt.text = GameManager.Instance.Character.Defense.ToString();
        healthTxt.text = GameManager.Instance.Character.Health.ToString();
        critTxt.text = GameManager.Instance.Character.Crit.ToString();
        UIManager.Instance.UIMainMenu.SetGold();
    }

    private void OnClickBackButton()
    {
        statusBack.Invoke();
    }
}
