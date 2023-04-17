using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

namespace Enemy
{
    public class Enemy : MonoBehaviour, IActions
    {
        [SerializeField] private float _speedMove;
        private SpriteRenderer _spriteRenderer;

        private void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _spriteRenderer.flipX = false;
            _speedMove = -0.03f;
        }

        private void FixedUpdate()
        {
            Move();
        }

        public void Move()
        {
            transform.Translate(_speedMove, 0, 0);
        }

        public void Jump()
        {
            throw new System.NotImplementedException();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("LeftPoint"))
            {
                _speedMove = 0.03f;
                _spriteRenderer.flipX = true;
            }

            if (other.gameObject.CompareTag("RightPoint"))
            {
                _speedMove = -_speedMove;
                _spriteRenderer.flipX = false;
            }
        }
    }   
}
