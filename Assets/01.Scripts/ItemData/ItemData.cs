using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ItemData", menuName ="Items/Item")]
public class ItemData : ScriptableObject
{
    [field: SerializeField] public int Attack { get; private set; }
    [field: SerializeField] public int Defense { get; private set; }
    [field: SerializeField] public int Health { get; private set; }
    [field: SerializeField] public int Crit { get; private set; }

    [field: SerializeField] public Sprite Icon { get; private set; }
}
