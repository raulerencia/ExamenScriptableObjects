using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "Weapon", menuName = "Weapon")]
public class Weapon : ScriptableObject
{
    public string weaponName;
    public int weaponDamage;
    public Sprite weaponImage;
}
