using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMain : MonoBehaviour {

	public float Health=50f;
    public float look_radius;
    public float damage = 5f;
    public float attack_delay = 5f;
    public float attack_range;
    private float attack_delay_buffor = 0f;
  //  public Animator anim;
    NavMeshAgent agent;
    Transform target;

    private void Start()
    {
        target = PlayerMains.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }
    // Update is called once per frame
    public void TakeDamage(float amount)
    {
        Health -= amount;
        if (Health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    public void DealDamage(float amount)
    {
       // anim.SetBool("EnemyAttack", true);
        FindObjectOfType<PlayerMains>().Health -= amount;
    }
    /*IEnumerator DealDamage(float amount, float delay)
        {
            yield return new WaitForSeconds(delay);
            FindObjectOfType<PlayerMains>().Health -= amount;
            // Now do your thing here
        }*/
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, look_radius);
    }
    private void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
      //  Debug.Log(distance);
        if(distance < attack_range)
        {
          //  anim.SetBool("PlayerClose", false);
                if(Time.time>=attack_delay_buffor)
                {
                attack_delay_buffor = Time.time + attack_delay;
                DealDamage(damage);
                }   
        }
        if(distance <= look_radius && distance >= attack_range)
        {
            agent.SetDestination(target.position);
           // anim.SetBool("PlayerClose", true);
           // anim.SetBool("EnemyAttack", false);
        }
        else
        {
          //  anim.SetBool("PlayerClose", false);
        }
    }
}
