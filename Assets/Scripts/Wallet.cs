using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wallet : MonoBehaviour
{
    private int nowGold;
    [SerializeField] private Text text;
    private void Update() 
    {
        text.text = GameManager.instance.userData.gold + " G";
    }
}
