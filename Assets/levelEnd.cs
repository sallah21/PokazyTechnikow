using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelEnd : MonoBehaviour {
   public Collider col;
  
	// Use this for initialization

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "End")
        {
        SceneManager.LoadScene("GameEnd");
        }

    }
 
}
