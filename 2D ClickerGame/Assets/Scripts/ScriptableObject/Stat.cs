using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Status", menuName = "Clcker/Stat", order = 0)]
public class Stat : ScriptableObject
{
    [Header("Stat Info")]
    public string statName;
    public string statDescription;
    public float statValue;
    public float statCost;

    public Sprite icon;
}
