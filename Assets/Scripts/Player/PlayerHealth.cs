using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public Transform _pointSpawnPlayer;
    [SerializeField] private Image[] _healthImage;
    public int numberOfLives;
    [SerializeField] private GameObject _panelGameOverLose;

    private void Start()
    {
        _pointSpawnPlayer = GameObject.Find("SpawnPlayer").transform;
    }

    private void FixedUpdate()
    {
        if (numberOfLives <= 0)
        {
            Destroy(gameObject);
            _panelGameOverLose.SetActive(true);
        }
    }

    private void Update()
    {
        if (health > numberOfLives)
        {
            health = numberOfLives;
        }
        
        for (int i = 0; i < _healthImage.Length; i++)
        {
            if (i < numberOfLives)
            {
                _healthImage[i].enabled = true;
            }
            else
            {
                _healthImage[i].enabled = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Spike"))
        {
            transform.position = _pointSpawnPlayer.position;
            numberOfLives -= 1;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            transform.position = _pointSpawnPlayer.position;
            numberOfLives -= 1;
        }
    }
}
