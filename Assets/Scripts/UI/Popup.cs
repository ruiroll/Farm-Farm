using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Popup : MonoBehaviour
{
    [SerializeField] private GameObject InventoryUI;
    
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
    
}
