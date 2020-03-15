using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {
    public float max_distance=100f;
    private void Update()
    {
        Ray rays=new Ray (transform.position , Vector3.forward);
        Debug.DrawRay(transform.position, Vector3.forward);
        if (Physics.Raycast(rays, max_distance))
        {
            Debug.Log("I hit something");
        }

    }
 
}

