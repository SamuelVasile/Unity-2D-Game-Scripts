using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Sprite[] HeartSprites;
    public Image HeartsUI;
    private PlayerHP player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent <PlayerHP>();
    }

    void Update()
    {
        HeartsUI.sprite = HeartSprites[player.currentHealth];
    }
}
