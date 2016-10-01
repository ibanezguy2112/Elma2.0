using UnityEngine;
using System.Collections;

namespace CompleteProject
{
    public class EnemyMovement : MonoBehaviour
    {
        Transform player;               // Reference to the player's position.
        NavMeshAgent nav;               // Reference to the nav mesh agent.
       // bool Inrange;
        public int offsetY;
        public int offsetX;

        void Awake()
        {
            // Set up the references.
            player = GameObject.FindGameObjectWithTag("Player").transform;
            nav = GetComponent<NavMeshAgent>();
           // Inrange = false;
        }


        void Update()
        {
            // If the enemy and the player have health left...
            // if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
            // {
            // if (Inrange)
            // {   
            transform.LookAt(new Vector3(offsetX, player.position.y + offsetY, 0));
            nav.SetDestination(player.position);
                  
                 
            // }
            //  else
            // {
            //nav.enabled = false;
            // }
        }

       /* void OnTriggerEnter(Collider other)
        {

            if (other.tag == "Player")
            {
                Inrange = true;
            }
        }

        void OnTriggerExit(Collider other)
        {

            if (other.tag == "Player")
            {
                Inrange = false;
            }

        }
*/
    }
}