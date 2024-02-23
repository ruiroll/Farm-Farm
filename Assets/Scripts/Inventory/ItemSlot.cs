using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;

public class ItemSlot : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private Text countTxt;
    [SerializeField] private GameObject EquipObject;

    private Item _item;
    public Item item {
        get { return _item; }
        set {
            _item = value;
            if (_item != null)
            {
                image.sprite = item.data.itemSprite;
                countTxt.text = item.count.ToString();
                image.color = new Color(1, 1, 1, 1);
                countTxt.color = new Color(0.2f, 0.2f, 0.2f, 1);
            }
            else
            {
                image.color = new Color(1, 1, 1, 0);
                countTxt.color = new Color(1, 1, 1, 0);
            }
        }
    }

    public void OnClickItem()
    {
        if(GameManager.instance.barrelActive)
        {
            if(transform.parent.name == "Bag")
            {
                GameManager.instance.sellItem.BagToBarrel(item);
            }
            else
            {
                GameManager.instance.sellItem.BarrelToBag(item);
            }
            GameManager.instance.popup.RefreshInventory();
            GameManager.instance.popup.RefreshBarrel();
        }
        else
        {
            item.isEquipped = !item.isEquipped;
            EquipObject.SetActive(item.isEquipped);
        }
        
    }
}
