using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Popup : MonoBehaviour
{
    [SerializeField] private Inventory inventory;
    [SerializeField] private Barrel barrel;
    [SerializeField] private GameObject InventoryUI;
    [SerializeField] private GameObject BarrelUI;
    
    private void Start() 
    {
        Refresh();
    }

    public void Refresh()
    {
        UserData userData = GameManager.instance.userData;
    }

    public void OpenInventory()
    {
        InventoryUI.SetActive(true);
    }
    public void CloseInventory()
    {
        InventoryUI.SetActive(false);
    }

    public void OpenBarrel()
    {
        BarrelUI.SetActive(true);
        GameManager.instance.barrelActive = true;
    }
    public void CloseBarrel()
    {
        BarrelUI.SetActive(false);
        GameManager.instance.barrelActive = false;
    }

    public void RefreshInventory()
    {
        inventory.FreshSlot();
    }

    public void RefreshBarrel()
    {
        barrel.FreshSlot();
    }
    
}
