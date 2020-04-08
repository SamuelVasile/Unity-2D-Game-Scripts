using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour {

    private bool attacking = false;
    private float attackTimer = 0;
    private float attackCD = 0.3f;

    public Collider2D attackTrigger;

    private Animator anim;

     void Awake()
    {
        anim = GetComponent<Animator>();
        attackTrigger.enabled = false;

    }


    // Update is called once per frame
    void Update () {
		
        if(Input.GetKeyDown("q") && !attacking)
        {
            attacking = true;
            attackTimer = attackCD;

            attackTrigger.enabled = true;
        }

        if(attacking)
        {
            if (attackTimer > 0)
            {
                attackTimer -= Time.deltaTime;
            }
            else
            {
                attacking = false;
                attackTrigger.enabled = false;
            }
        }
        anim.SetBool("attacking", attacking);
	}
}
