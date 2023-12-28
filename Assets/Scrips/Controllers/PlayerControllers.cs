using System;
using UnityEngine;

public class PlayerControllers : MonoBehaviour
{
    public event Action OnJumpEvent;
    public event Action OnAttackEvent;

    public void CallJumpEvent()
    {
        OnJumpEvent?.Invoke();
    }
    public void CallAttckEvent()
    {
        OnAttackEvent?.Invoke();
    }
}
