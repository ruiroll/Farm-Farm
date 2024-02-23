using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "items", menuName = "Data/item")]
public class Items : ScriptableObject
{
    public string itemName;
    public Sprite itemSprite;
}
