using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShooting : MonoBehaviour {

    public Camera camera;
    public float range=100f;
    public float damage = 10f;
    RaycastHit hit;
    public GameObject door;
    public GameObject impactEffect;
    public AudioSource shoot;


    // Update is called once per frame
    void Update ()
    {
        shoot.loop = false;
        int layerMask = 1 << 9;
        Debug.DrawRay(camera.transform.position, camera.transform.forward,Color.red);
        if (Input.GetButtonDown("Fire1")&&FindObjectOfType<PlayerMains>().Ammo>0)
        {
            FindObjectOfType<PlayerMains>().ammo_cap -= 1;
            shoot.Play(); ;
           // Debug.Log(FindObjectOfType<PlayerMains>().Ammo);
            if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, range, layerMask))
            {
                EnemyMain target = hit.transform.GetComponent<EnemyMain>();
                if(target!=null)
                {
                    target.TakeDamage(damage);
                }
                    Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
               // Debug.Log(hit.collider.name);
            }
        }

	}
}
