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
    public int count;
    public bool isEquipped;
    public Items data;
}

public class GameManager : MonoBehaviour
{
    public List<Item> barrel = new List<Item>();
    public SellItem sellItem;
    public Popup popup;
    public UserData userData;
    public static GameManager instance;
    public bool barrelActive = false;

    private void Awake() 
    {
        if(instance == null) instance = this;
        else Destroy(gameObject);
    }
}
