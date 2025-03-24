using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
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


    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
