using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show_HP : MonoBehaviour {
    public Player player;
    public Text text;
	// Use this for initialization
	void Start () {
        player = Player.FindObjectOfType<Player>();
        text.text = (player.heatlh).ToString() + " / " + (player.max_heatlh).ToString() + " / " + (player.armor).ToString() + " " + (player.max_armor).ToString();
	}
	
	// Update is called once per frame
	void Update () {

        text.text = "HP " +(player.heatlh).ToString() + "/" + (player.max_heatlh).ToString() + " AP " + (player.armor).ToString() + "/" + (player.max_armor).ToString();
    }
}
