using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected CharacterController controller;

    private static readonly int FrontWalking = Animator.StringToHash("Front");
    private static readonly int BackWalking = Animator.StringToHash("Back");
    private static readonly int LeftWalking = Animator.StringToHash("Left");
    private static readonly int RightWalking = Animator.StringToHash("Right");
    private static readonly int Attack = Animator.StringToHash("Attack");

    protected void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<CharacterController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        controller.OnHarvestEvent += Harvest;
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 obj)
    {
        if(obj.x > 0)
        {
            animator.SetBool(RightWalking, true);
        }
        else if(obj.x < 0)
        {
            animator.SetBool(LeftWalking, true);
        }

        if(obj.y > 0)
        {
            animator.SetBool(BackWalking, true);
        }
        else if(obj.y < 0)
        {
            animator.SetBool(FrontWalking, true);
        }

        if(obj.x == 0)
        {
            animator.SetBool(LeftWalking, false);
            animator.SetBool(RightWalking, false);
        }
        if(obj.y == 0)
        {
            animator.SetBool(FrontWalking, false);
            animator.SetBool(BackWalking, false);
        }
    }
    private void Harvest(Vector2 obj)
    {
        animator.SetTrigger("Harvest");
    }
}
