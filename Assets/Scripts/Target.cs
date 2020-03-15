using UnityEngine.AI;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Target : MonoBehaviour {
    public Player player ; 
public NavMeshAgent agent;
public CharacterController enemy;
    public float health;
    public float damage = 5;
    Vector3 move;
	// Use this for initialization
	void Start () {
	 agent = GetComponent<NavMeshAgent>();
        enemy = GetComponent<CharacterController>();
        player = Player.FindObjectOfType<Player>();
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(transform.position, player.transform.position) < 30)
        {
            agent.SetDestination(player.transform.position);
          //  Debug.Log("ide po ciebie");
            // Jeżeli odległość bd mniejsza niz 5 zaczyna bić
            if (Vector3.Distance(transform.position, player.transform.position) < 5.0f)
            {
                
                Debug.Log("Bije cie ");

                player.TakeDamage(damage);
            }
            Debug.Log("Zycie " + player.heatlh );
        }
        move = new Vector3(0, -0.5f, 0);
        move = transform.TransformDirection(move);
        enemy.Move(move);
	}
    

}
