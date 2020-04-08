using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    public int currentHP;
    public int maxHP;

    public float distance;
    public float shootInterval;
    public float arrowSpeed = 5;
    public float arrowTimer;

    public GameObject arrow;
    public Transform target;
    public Transform ShootArrowLeft;

	// Use this for initialization
	void Start () {

        currentHP = maxHP;
	}
	
	// Update is called once per frame
	void Update () {

        rangeCheck();

        if (currentHP <= 0)
        {
            Destroy(gameObject);
        }
        
	}

    void rangeCheck()
    {
        distance = Vector3.Distance(transform.position, target.transform.position);

        
    }

    public void attack(bool attackingLeft)
    {
        arrowTimer += Time.deltaTime;

        if(arrowTimer >= shootInterval)
        {
            Vector2 direction = target.transform.position - transform.position;
            direction.Normalize();

            if (attackingLeft)
            {
                GameObject arrowClone;
                arrowClone = Instantiate(arrow, ShootArrowLeft.transform.position, ShootArrowLeft.transform.rotation) as GameObject;
                arrowClone.GetComponent<Rigidbody2D>().velocity = direction * arrowSpeed;

                arrowTimer = 0;
            }
        }
    }

    public void Damage(int damage)
    {
        currentHP -= damage;
        
    }
}
