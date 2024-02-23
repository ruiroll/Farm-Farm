using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour //Inventory
{
    [SerializeField] private GameObject bag;
    [SerializeField] private Transform slotParent;
    [SerializeField] private ItemSlot[] slots;

    private void OnValidate() // change slots if changed by editor
    {
        slots = slotParent.GetComponentsInChildren<ItemSlot>();
    }

    private void Start() 
    {
        FreshSlot();
    }

    public void FreshSlot() // reload slots & show items
    {
        int i = 0;
        for(; i < GameManager.instance.userData.inventory.Count && i < slots.Length; i++)
        {
            slots[i].item = GameManager.instance.userData.inventory[i];
        }
        for(; i < slots.Length; i++)
        {
            slots[i].item = null;
        }
    }
}
