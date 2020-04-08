using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackCone : MonoBehaviour {

    public EnemyAI goblinAI;

    void Awake()
    {
        goblinAI = gameObject.GetComponentInParent<EnemyAI>();
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            goblinAI.attack(true);
        }
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
