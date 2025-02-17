using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAiChase : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float speed;

    [SerializeField] private Animator animator;
    private float distance;
    //[SerializeField] private LayerMask targetLayers;
  


   
    void Update()
    {

        Vector3 direction = player.transform.position - transform.position;
        direction.Normalize();
        
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

        if (direction != Vector3.zero)
        {
            //animator.SetFloat("isWalking", speed);
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * speed);
        }
    }



    
}
