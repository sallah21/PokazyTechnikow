using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUN : MonoBehaviour {
    public float damage = 10f;
    public float range = 100f;
    public Camera fpscam;
    float dmg=5f;
    public Sprite pistol;
    public Sprite aftershootpistol;
    public SpriteRenderer render;
    public muzzle muzz;
    private void Start()
    {
        muzz = muzzle.FindObjectOfType<muzzle>();
    }

    // Update is called once per frame
    void FixedUpdate () {
        if (Input.GetButtonDown("Fire1"))
        {
            muzz.muzzpart.Play();
            StartCoroutine("shotAnim");
            
            shoot();         
        }
    }
    void shoot()
    {
        RaycastHit hitinfo;
       if (Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hitinfo, range))
        {          
            if(hitinfo.collider.tag=="Enemy")
            {           
                
                Enemy target = hitinfo.collider.GetComponent<Enemy>();
                target.health -= dmg;
                Debug.Log(target.health);
            }
        }

     }
    IEnumerator shotAnim()
    {      
        render.sprite = aftershootpistol;
        yield return new WaitForSeconds(0.05f);
        render.sprite = pistol;       
    }
}
