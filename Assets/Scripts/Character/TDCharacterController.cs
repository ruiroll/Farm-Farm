using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDCharacterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnHarvestEvent;
    public event Action OnInventoryEvent;

    public bool moveable = true;
    public bool harvestable = false;
    public bool inventoryOpened = false;


    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallHarvestEvent(Vector2 position)
    {
        OnHarvestEvent?.Invoke(position);
    }

    public void CallInventoryEvent()
    {
        OnInventoryEvent?.Invoke();
    }
}
