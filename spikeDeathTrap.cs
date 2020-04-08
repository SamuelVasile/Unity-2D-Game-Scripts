﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeDeathTrap : MonoBehaviour {

    private PlayerHP player;

    // Use this for initialization
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHP>();

    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            player.Damage(5);
        }
    }
}
