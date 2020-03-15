using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowDeath : MonoBehaviour {
    public GameObject player;
    public Text text;
	// Use this for initialization
	void Start () {
       text = text.GetComponent<Text>();
        text.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (FindObjectOfType<PlayerMains>().Health <= 0)
        {
            
            text.enabled = true;
            StartCoroutine("Wait");
            
        }
	}
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
       
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
