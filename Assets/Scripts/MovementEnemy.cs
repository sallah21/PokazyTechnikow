
using UnityEngine;

public class MovementEnemy : MonoBehaviour {
    public CharacterController player;
    public float grav=0.5f;
    Vector3 movement_direction;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // var x = Input.GetAxisRaw("Horizontal")*2f;
        //var z = Input.GetAxisRaw("Vertical")*(0.5f);
        movement_direction = new Vector3(0 ,-grav,0 );
        movement_direction = transform.TransformDirection(movement_direction);
        player.Move(movement_direction);
        
	}
}
