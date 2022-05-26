using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItem : MonoBehaviour
{
    public Weapon weapon;
    public Armor armor;
    public Inventory inventory;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player")){
            
            if(this.gameObject.tag.Equals("Weapon")){
                inventory.AddWeapon(weapon);
                Destroy(this.gameObject);
            }else if(this.gameObject.tag.Equals("Armor")){
                inventory.AddArmor(armor);
                Destroy(this.gameObject);
            }
            
        }
    }
}
