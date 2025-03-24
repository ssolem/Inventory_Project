using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [Header("ĳ���� ����")]
    [SerializeField] private int attack;
    [SerializeField] private int defense;
    [SerializeField] private int health;
    [SerializeField] private int crit;

    public int Attack { get { return attack; } private set { attack = value; } }
    public int Defense { get { return defense; } private set { defense = value; } }
    public int Health {  get { return health; } private set { health = value; } }
    public int Crit { get { return crit; } private set { crit = value; } }

}
