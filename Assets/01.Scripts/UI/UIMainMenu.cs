using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;

public class UIMainMenu : UIPopUp
{
    [Header("플레이어 정보")]
    [SerializeField] private TextMeshProUGUI nameTxt;
    [SerializeField] private TextMeshProUGUI descriptionTxt;
    [SerializeField] private TextMeshProUGUI goldTxt;
    [SerializeField] private TextMeshProUGUI levelTxt;
    [SerializeField] private Image expBar;

    [Header("메인 메뉴")]
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;
    private TextMeshProUGUI statusTxt;
    private TextMeshProUGUI inventoryTxt;

    public Action StatusOpen;
    public Action InventoryOpen;

    private int exp;
    private int maxExp;

    protected override void Start()
    {
        base.Start();

        statusTxt = statusButton.GetComponentInChildren<TextMeshProUGUI>();
        inventoryTxt = inventoryButton.GetComponentInChildren<TextMeshProUGUI>();

        statusButton.onClick.AddListener(OnClickStatusButton);
        inventoryButton.onClick.AddListener(OnClickInventoryButton);

        ButtonFadeEvents();
        SetInfo();
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            OpenUI();
        }
        SetLevel();
    }

    void ButtonFadeEvents()
    {
        StatusOpen += ButtonFadeOut;
        InventoryOpen += ButtonFadeOut;
        UIManager.Instance.UIStatus.statusBack += ButtonFadeIn;
        UIManager.Instance.UIInventory.inventoryBack += ButtonFadeIn;
    }

    private void OnClickStatusButton()
    {
        StatusOpen.Invoke();
    }

    private void OnClickInventoryButton()
    {
        InventoryOpen.Invoke();
    }

    public void ButtonFadeOut()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(statusButton.image.DOFade(0, 0.4f));
        sequence.Join(inventoryButton.image.DOFade(0, 0.4f));
        sequence.Join(statusTxt.DOFade(0, 0.4f));
        sequence.Join(inventoryTxt.DOFade(0, 0.4f));
        sequence.OnComplete(() =>
        {
            statusButton.gameObject.SetActive(false);
            inventoryButton.gameObject.SetActive(false);
        }
            );
    }


    public void ButtonFadeIn()
    {
        Sequence sequence = DOTween.Sequence();
        statusButton.gameObject.SetActive(true);
        inventoryButton.gameObject.SetActive(true);

        sequence.Append(statusButton.image.DOFade(1, 0.4f));
        sequence.Join(inventoryButton.image.DOFade(1, 0.4f));
        sequence.Join(statusTxt.DOFade(1, 0.4f));
        sequence.Join(inventoryTxt.DOFade(1, 0.4f));
    }

    private void SetInfo()
    {
        nameTxt.text = GameManager.Instance.Character.PlayerName;
        descriptionTxt.text = GameManager.Instance.Character.Description;       
    }

    private void SetLevel()
    {
        exp = GameManager.Instance.Character.Exp;
        maxExp = GameManager.Instance.Character.MaxExp;
        expBar.fillAmount = (float)exp % maxExp == 0 ? 0 : (float)exp / maxExp;
        levelTxt.text = "Lv. " + (exp / maxExp + 1).ToString();
    }

    public void SetGold()
    {
        int gold = GameManager.Instance.Character.Gold;
        goldTxt.text = DevideByThousands(gold);
    }

    string DevideByThousands(int number)
    {
        int count = 0;
        string result = "";

        while (number > 0)
        {
            int unit = number % 1000;
            number /= 1000;

            if(unit > 0)
            {
                if(count == 0)
                {
                    result = unit.ToString();

                }
                else
                {
                    result = unit.ToString() + "," + result;
                }
            }
            count++;
        }

        return result;
    }
}
