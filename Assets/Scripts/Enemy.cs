
using UnityEngine;

public class Enemy : MonoBehaviour {
   public float health;
	// Use this for initialization
	void Start () {
        health = 10;

    }
	
	// Update is called once per frame
	void Update () {



		if (health <= 0)
        {
            Destroy(gameObject);
        }
	}
}
