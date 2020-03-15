using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    private float yAxis;
    public Transform trans;
    /*public float Axisx=10f;
    public float Axisy=5f;
    public float speed = 3f;*/
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(trans.transform.position.x, trans.transform.position.y+0.8f, trans.transform.position.z);
        yAxis = Input.GetAxisRaw("Mouse Y");
        transform.Rotate(yAxis*-1f, 0f, 0f);
      /*  Debug.Log(Input.GetAxis("Mouse Y"));
        transform.Rotate(-Input.GetAxis("Mouse Y") * Axisx , Input.GetAxis("Mouse X") * Axisy , 0);*/
        
    }
}