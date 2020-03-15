using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMains : MonoBehaviour
{
    public CharacterController controller;

    public float Health = 50f;
    public float Armor = 0f;
    public float Ammo = 30f;
    public float ammo_cap = 100f;
        
    public float gravity;
    public float movement_speed;
    public float speed_bufor;
    public float sprint_force;
    public float jump_force;
    private Vector3 movement_direction;

    private float yAxis;

    public bool red ;
    public bool blue ;
    public bool yellow ;
    public bool green;
    public float max_distance;

    public float Sensitivity;

    public static PlayerMains instance;
    public GameObject player;
    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
        speed_bufor = movement_speed + sprint_force;
    }

    //Enemy AI
    void Awake()
    {
        instance = this;
    }
    public void PickupColor(string color)
    {
        if (color == "red") red = true;
        if (color == "blue") blue = true;
        if (color == "green") green = true;
        if (color == "yellow") yellow = true;
    }
    // Update is called once per frame
    void Update()
    {
        //Directions via WSAD rotating directions
        movement_direction = new Vector3(Input.GetAxis("Horizontal") * movement_speed, movement_direction.y, Input.GetAxis("Vertical") * movement_speed);
        movement_direction = transform.TransformDirection(movement_direction);
        yAxis = Input.GetAxisRaw("Mouse X");
        //Jumping
        if (Input.GetButtonDown("Jump"))
        {
            movement_direction.y = jump_force;
        }
        //sprint
        if (Input.GetKey("left shift"))
        {
            movement_speed = speed_bufor;
        }
        else
        {
            movement_speed = speed_bufor - sprint_force;
        }
        //gravity
        movement_direction.y = movement_direction.y + (Physics.gravity.y * gravity);
        //rotating
        Vector3 _rotation = new Vector3(0f, yAxis , 0f) * Sensitivity;
        controller.transform.Rotate(_rotation);

        //Actual moving
        controller.Move(movement_direction * Time.deltaTime);

        //Health
        if(Health>100)
        {
            Health = 100;
        }
        


        
    }
}
