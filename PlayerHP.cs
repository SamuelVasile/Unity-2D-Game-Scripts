using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour {
    public int maxHealth=100;
    public int currentHealth;
   

	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;
        
	}
	
	// Update is called once per frame
	void Update () {

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        if (currentHealth <= 0)
        {
            Die();
        }


	}
    
    void Die()
    {
        Application.LoadLevel(Application.loadedLevel);

    }

    public void Damage(int dmg)
    {
        currentHealth -= dmg;
        //gameObject.GetComponent<Animation>().Play("playerHurt");
    }
}
