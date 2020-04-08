﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.isTrigger != true)
        {
            if (col.CompareTag("Player"))
            {
                col.GetComponent<PlayerHP>().Damage(1);
            }

            Destroy(gameObject);
        }
    }
}
