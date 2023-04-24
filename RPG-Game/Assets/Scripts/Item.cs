using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [Header("Item Type")]
    public bool isItem;
    public bool isWeapon;
    public bool isArmor;

    [Header("Item Details")]
    public string itemName;
    public string description;
    public int value;
    public Sprite itemSprite;

    [Header("Item Details")]
    public int amountToChange;
    public bool affectHP, affectMP, affectStr;

    [Header("Weapon/Armor Details")]
    public int weaponStrenght;

    public int armorStrenght;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   /* public void Use()
    {
        if (isItem) 
        {
            if(affectHP) 
            {
                CharStats.currentHP += amountToChange;
                if(CharStats.currentHP > CharStats.maxHP)
                {
                    CharStats.currentHP = CharStats.maxHP;
                }
            }
            if (affectMP)
            {
                CharStats.currentMP += amountToChange;
                if (CharStats.currentMP > CharStats.maxMP)
                {
                    CharStats.currentMP = CharStats.maxMP;
                }
            }

            if(affectStr)
            {
                CharStats.strength = amountToChange;
            }
        }

        if(isWeapon)
        {
            if(CharStats.equippedWeapon != "")
            {
                GameManager.instance.AddItem(equippedWeapon);
            }

            CharStats.equippedWeapon = itemName;
            CharStats.weaponPower = weaponStrenght;

        }

        if(isArmor)
        {
            if (CharStats.equippedArmor != "")
            {
                GameManager.instance.AddItem(equippedArmor);
            }

            CharStats.equippedArmor = itemName;
            CharStats.armorPower = armorStrenght;
        }

        GameManager.instance.RemoveItem(itemName);
    }*/
}
