using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackTrigger : MonoBehaviour {

    public int dmg = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.isTrigger != true)
        {
            collision.SendMessageUpwards("Damage", dmg);
        }
    }
}
