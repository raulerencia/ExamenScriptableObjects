using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Armor", menuName = "Armor")]
public class Armor : ScriptableObject
{
    public string armorName;
    public int armorProtection;
    public Sprite armorImage;
}
