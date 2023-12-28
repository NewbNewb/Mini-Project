using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : PlayerControllers
{
    void OnJump()
    {
        CallJumpEvent();
    }
    void OnAttack()
    {
        CallAttckEvent();
    }
}
