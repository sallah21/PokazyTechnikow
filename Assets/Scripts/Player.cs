using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public float heatlh ;
    public float max_heatlh = 100f;
    public CharacterController player;
    public float armor;
    public float max_armor = 100f;
    bool CanDamage;
	// Use this for initialization
	void Start () {
        heatlh = max_heatlh - 10f;
        armor = 0;
        player = player.GetComponent<CharacterController>();
        CanDamage = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (heatlh > max_heatlh) heatlh = max_heatlh;
        if (armor > max_armor) armor = max_armor; 
		if ( heatlh<=0)
        {
            Debug.Log("nie zyjesz");
            player.enabled = false;
        }
	}
   public void TakeDamage(float damage)
    {
        
        if ( CanDamage == true && this.armor == 0)
        {
            this.heatlh -= damage;
            StartCoroutine("timer");
        }
        else if( CanDamage == true) 
        {
            this.armor -= damage;
            StartCoroutine("timer");
        }
    }
    private IEnumerator timer()
    {
        CanDamage = false;
        yield return new WaitForSeconds(1);
        CanDamage = true;
    }
}
