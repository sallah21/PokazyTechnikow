using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUp : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player" && FindObjectOfType<PlayerMains>().Health < 100)
        {
            Picking_up();
        }
    }
    void Picking_up()
    {
        FindObjectOfType<PlayerMains>().Health += 10f;
        Destroy(this.gameObject);
    }
}
