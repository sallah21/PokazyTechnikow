using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateAmmo : MonoBehaviour {

    public PlayerMains player;
    public Text text;
    // Use this for initialization
    void Start()
    {
        player = Player.FindObjectOfType<PlayerMains>();
        text.text = (player.Ammo).ToString() + " / " + (player.ammo_cap).ToString();
    }

    // Update is called once per frame
    void Update()
    {

        text.text = (player.ammo_cap).ToString();
    }
}
