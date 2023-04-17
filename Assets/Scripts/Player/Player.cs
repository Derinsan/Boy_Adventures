using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour, IActions
{
    private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _jumpForce;
    private bool _isGround;
    private string _directionMove;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;
    private float _horizontalSpeed = 0f;
    [SerializeField] private float _speedMove;
    private bool _jump;

    //[SerializeField] private Transform _groundCheck;
    //private float _groundRadius = 0.2f;
    //[SerializeField] private LayerMask _whatIsGround;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _directionMove = "";
        _jump = false;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _isGround = true;
            _animator.SetBool("Jump", false);
            _jump = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _isGround = false;
        }
    }

    private void Update()
    {
        Move();
    }

    /*private void FixedUpdate()
    {
        _isGround = Physics2D.OverlapCircle(_groundCheck.position, _groundRadius, _whatIsGround);

        if (_isGround == true)
        {
            _animator.SetBool("Jump", false);
            _jump = false;
        }
    }*/

    public void Move()
    {
        _horizontalSpeed = Input.GetAxis("Horizontal");
        
        if (_directionMove == "Left")
        {
            _horizontalSpeed = -0.01f;
            _spriteRenderer.flipX = true;
            
            if (_jump == false && _isGround == false)
            {
                _animator.SetBool("Fall", true);
            }
            else if(_jump == false && _isGround == true)
            {
                _animator.SetBool("Fall", false);
                _animator.SetBool("Run", true);
            }
            else if (_jump == true && _isGround == true)
            {
                _animator.SetBool("Fall", false);
                _animator.SetBool("Run", true);
            }
            else if (_jump == true && _isGround == false)
            {
                _animator.SetBool("Jump", true);
            }
        }
        else if (_directionMove == "Right")
        {
            _horizontalSpeed = 0.01f;
            _spriteRenderer.flipX = false;

            if (_jump == false && _isGround == false)
            {
                _animator.SetBool("Fall", true);
            }
            else if(_jump == false && _isGround == true)
            {
                _animator.SetBool("Fall", false);
                _animator.SetBool("Run", true);
            }
            else if (_jump == true && _isGround == true)
            {
                _animator.SetBool("Fall", false);
                _animator.SetBool("Run", true);
            }
            else if (_jump == true && _isGround == false)
            {
                _animator.SetBool("Jump", true);
            }
        }
        else if (_directionMove == "")
        {
            _animator.SetBool("Run", false);
            
            if (_jump == false && _isGround == false)
            {
                _animator.SetBool("Fall", true);
            }
            else
            {
                _animator.SetBool("Fall", false);
            }
        }

        transform.Translate(_horizontalSpeed * _speedMove * Time.deltaTime, 0, 0);
    }

    public void Jump()
    {
        if (_isGround == true)
        {
            _animator.SetBool("Jump", true);
            _jump = true;
            _rigidbody2D.velocity = Vector2.up * _jumpForce;
        }
    }

    public void LeftButton()
    {
        _directionMove = "Left";
    }

    public void RightButton()
    {
        _directionMove = "Right";
    }

    public void NoMove()
    {
        _directionMove = "";
    }

    public void JumpButton()
    {
        Jump();
    }
}
}

