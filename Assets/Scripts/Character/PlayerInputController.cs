using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements.Experimental;

public class PlayerInputController : TDCharacterController
{
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnHarvest()
    {
        Vector2 nowPosition = transform.position;
        CallHarvestEvent(nowPosition);
    }

    public void OnInventory()
    {
        CallInventoryEvent();
    }
}