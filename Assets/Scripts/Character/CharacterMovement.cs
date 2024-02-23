using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private TileChange tileChange;
    private TDCharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _controller = GetComponent<TDCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnInventoryEvent += Inventory;
        _controller.OnMoveEvent += Move;
        _controller.OnHarvestEvent += Harvest;
    }

    private void FixedUpdate()
    {
        if(_controller.moveable == false)
        {
            ApplyMovment(Vector2.zero);
        }
        else 
        {
            ApplyMovment(_movementDirection);
        }
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovment(Vector2 direction)
    {
        direction = direction * 5;

        _rigidbody.velocity = direction;
    }

    private void Harvest(Vector2 position)
    {
        if(_controller.harvestable)
        {
            _controller.moveable = false;
            Vector3 pos = new Vector3(position.x - 0.5f, position.y - 0.5f, 0f);
            tileChange.ChangeTileType(pos);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Farmland")
        {
            _controller.harvestable = true;
        }    
    }
    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.tag == "Farmland")
        {
            _controller.harvestable = false;
        }
    }

    public void Inventory()
    {
        _controller.inventoryOpened = !_controller.inventoryOpened;
        if(_controller.inventoryOpened)
        {
            GameManager.instance.popup.OpenInventory();
        }
        else
        {
            GameManager.instance.popup.CloseInventory();
        }
    }
}
