using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorPickup : MonoBehaviour {

    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {
        if(other.name=="Player")
        {
            Armorup();
        }
    }

    // Update is called once per frame
    void Armorup()
    {
        FindObjectOfType<PlayerMains>().Armor+=25;
        Destroy(this.gameObject);
    }
}
