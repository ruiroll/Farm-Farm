using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SellItem : MonoBehaviour
{
    public void BagToBarrel(Item item)
    {
        Item nowItem = GameManager.instance.userData.inventory.Find(element => element.data.name == item.data.name);
        int idx = GameManager.instance.userData.inventory.FindIndex(element => element.data.name == item.data.name);
        nowItem.count--;
        if(nowItem.count <= 0)
        {
            GameManager.instance.userData.inventory.Remove(nowItem);
        }
        Item thisItem = GameManager.instance.barrel.Find(element => element.data.name == item.data.name);
        if(thisItem != null) thisItem.count++;
        else 
        {
            thisItem = new Item();
            thisItem.count = 1;
            thisItem.data = item.data;
            GameManager.instance.barrel.Add(thisItem);
        }
    }
    
    public void BarrelToBag(Item item)
    {
        Item nowItem = GameManager.instance.barrel.Find(element => element.data.name == item.data.name);
        nowItem.count--;
        if(nowItem.count <= 0)
        {
            GameManager.instance.barrel.Remove(nowItem);
        }
        Item thisItem = GameManager.instance.userData.inventory.Find(element => element.data.name == item.data.name);
        if(thisItem != null) thisItem.count++;
        else 
        {
            GameManager.instance.userData.inventory.Find(element => element.data.name == item.data.name).count = 1;
        }
    }
}
