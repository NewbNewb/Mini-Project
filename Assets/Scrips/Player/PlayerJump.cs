using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private PlayerControllers _controllers;
    private Animator _animator;

    [SerializeField] private float JumpPower;
    private Rigidbody2D _rb;
    private bool isJump = false;

    private void Awake()
    {
        _controllers = GetComponent<PlayerControllers>();
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponentInChildren<Animator>();
    }
    private void Start()
    {
        _controllers.OnJumpEvent += Jump;
    }

    private void Jump()
    {
        if (!isJump)
        {
            _animator.SetBool("isJump", true);
            isJump = true;
            _rb.AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Ground"))
        {
            _animator.SetBool("isJump", false);
            isJump = false;
        }
    }

}
