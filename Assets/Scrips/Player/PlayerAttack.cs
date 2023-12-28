using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private PlayerControllers _controllers;
    private Animator _animator;

    public int attackDMG;
    private float curTime;
    [SerializeField] private float coolTime = 0.5f;

    private void Awake()
    {
        _controllers = GetComponent<PlayerControllers>();
        _animator = GetComponentInChildren<Animator>();
    }
    private void Start()
    {
        _controllers.OnAttackEvent += Attack;
    }
    private void Update()
    {
        curTime -= Time.deltaTime;
    }

    private void Attack()
    {
        if (curTime <= 0)
        {
            _animator.SetTrigger("isAttack");
            curTime = coolTime;
        }
    }

}
