using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelCollide : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("collide");
        if(other.gameObject.tag == "Player")
        {
            GameManager.instance.popup.OpenBarrel();
            GameManager.instance.popup.OpenInventory();
        }
    }
    private void OnCollisionExit2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            GameManager.instance.popup.CloseBarrel();
            GameManager.instance.popup.CloseInventory();
        }
    }
}
