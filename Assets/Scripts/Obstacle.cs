using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        _playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            _playerMovement.Die();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
