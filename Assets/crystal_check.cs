using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystal_check : MonoBehaviour
{
    public PlayerMains player;
    // Start is called before the first frame update
    public string color;
    void Start()
    {
      player =  FindObjectOfType<PlayerMains>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(this.transform.position, player.transform.position)< 5 && Input.GetKeyDown("e"))
        {
            Debug.Log(color);
            player.PickupColor(color); 
        }
    }
}
