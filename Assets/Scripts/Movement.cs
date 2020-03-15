
using UnityEngine;

public class Movement : MonoBehaviour {
    public CharacterController player;
    public float grav=(-0.5f);
    Vector3 movement_direction;
	// Use this for initialization
	void Start () {
        player = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update () {
       //  var x = Input.GetAxisRaw("Horizontal");
      //  var z = Input.GetAxisRaw("Vertical") * (0.5f);
        movement_direction = new Vector3(Input.GetAxis("Horizontal") * 0.5f, - grav, Input.GetAxis("Vertical") );
       var mouse = Input.GetAxis("Mouse X");
        movement_direction = transform.TransformDirection(movement_direction);
        player.Move(movement_direction);
        player.transform.Rotate(0, mouse, 0);
	}
}
