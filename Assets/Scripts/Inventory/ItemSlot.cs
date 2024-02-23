using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ItemSlot : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private GameObject EquipObject;

    private Item _item;
    public Item item {
        get { return _item; }
        set {
            _item = value;
            if (_item != null)
            {
                image.sprite = item.data.itemSprite;
                image.color = new Color(1, 1, 1, 1);
            }
            else
            {
                image.color = new Color(1, 1, 1, 0);
            }
        }
    }

    public void OnClickItem()
    {
        item.isEquipped = !item.isEquipped;
        EquipObject.SetActive(item.isEquipped);
        GameManager.instance.ItemEquip();
    }
}
