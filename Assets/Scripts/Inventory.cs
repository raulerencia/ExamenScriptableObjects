using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<Weapon> weaponList;
    public List<Armor> armorList;

    public List<Image> itemImage;
    public List<Text> itemName;
    public List<Text> itemPower;


    public void AddWeapon(Weapon newWeapon){
        weaponList.Add(newWeapon);
    }

    public void showWeapons(){
        for(int i = 0; i < weaponList.Count; i++){
            //itemImage[i].image = weaponList[i].weaponImage;
            itemName[i].text = weaponList[i].weaponName;
            itemPower[i].text = "Damage: "+weaponList[i].weaponDamage;
        }
    }

    public void AddArmor(Armor newArmor){
        armorList.Add(newArmor);
    }

    public void showArmors(){
        for(int i = 0; i < armorList.Count; i++){
            //itemImage[i].sprite = armorList[i].armorImage;
            itemName[i].text = armorList[i].armorName;
            itemPower[i].text = "Protection: "+armorList[i].armorProtection;
        }
    }
    
}
