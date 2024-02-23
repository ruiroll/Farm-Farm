using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


[System.Serializable]
public class UserData
{
    public string Name;
    public int gold;
    public List<Item> inventory = new List<Item>();
}

[System.Serializable]
public class Item
{
    public bool isEquipped;
    public Items data;
}

public class GameManager : MonoBehaviour
{
    public Popup popup;
    public UserData userData;
    public static GameManager instance;

    private void Awake() 
    {
        if(instance == null) instance = this;
        else Destroy(gameObject);
    }

    public void ItemEquip()
    {
        popup.Refresh();
    }
}
