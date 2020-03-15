using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpening : MonoBehaviour {
    public Animator opeing;
    public CharacterController player;
    
    int open = Animator.StringToHash("opening");
	// Use this for initialization
	void Start () {

        opeing = GetComponent<Animator>();

        opeing.enabled = false;
      //  player = gameObject.GetComponent<CharacterController>();
	}
 

// Update is called once per frame
void Update () {
        AnimatorStateInfo stateInfo = opeing.GetCurrentAnimatorStateInfo(0);
        if (Vector3.Distance(player.transform.position, this.transform.position) > 2.0)
        {
          //  Debug.Log(Vector3.Distance(player.transform.position, this.transform.position));
        }
        if (Vector3.Distance(player.transform.position,this.transform.position) < 2.0 && Input.GetKeyDown("e"))
        {
            Debug.Log("colide decectd");
            this.opeing.enabled = true;
        }
  
    }
}
