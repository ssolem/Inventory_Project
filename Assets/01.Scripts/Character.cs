using System;
using UnityEngine;

public class Character : MonoBehaviour
{
    [Header("캐릭터 스탯")]
    [SerializeField] private int attack;
    [SerializeField] private int defense;
    [SerializeField] private int health;
    [SerializeField] private int crit;

    [Header("캐릭터 정보")]
    [SerializeField][Range(0, 200)] private int exp;
    [SerializeField] private int maxExp;
    [SerializeField] private int gold;
    [SerializeField] private string playerName;
    [SerializeField] private string description;

    private ItemData equipData;
    public Action Equip;
    public Action UnEquip; 

    public int Attack { get { return attack; } private set { attack = value; } }
    public int Defense { get { return defense; } private set { defense = value; } }
    public int Health {  get { return health; } private set { health = value; } }
    public int Crit { get { return crit; } private set { crit = value; } }
    public int Exp { get { return exp; } private set { exp = value; } }
    public int MaxExp { get { return maxExp; } private set { maxExp = value; } }
    public int Gold {  get { return gold; } private set { gold = value; } }
    public string PlayerName { get { return playerName; } private set { playerName = value; } }
    public string Description { get { return description; } private set { description = value; } }

    private void Start()
    {
        Equip += OnEquip;
        UnEquip += OnUnEquip;
    }

    void OnEquip()
    {
        attack += equipData.Attack;
        defense += equipData.Defense;
        health += equipData.Health;
        crit += equipData.Crit;
    }

    void OnUnEquip()
    {
        attack -= equipData.Attack;
        defense -= equipData.Defense;
        health -= equipData.Health;
        crit -= equipData.Crit;
    }

    public void GetEquipData(ItemData data)
    {
        equipData = data;
    }

}
