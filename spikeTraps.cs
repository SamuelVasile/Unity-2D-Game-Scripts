using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeTraps : MonoBehaviour {

    private PlayerHP player;
    public playerController plc;

	// Use this for initialization
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHP>();

	}
	
	// Update is called once per frame
	void Update () {
		

	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            player.Damage(3);

            //StartCoroutine(plc.Knockback(0.02f, 350, plc.transform.position));
        }
    }
}
