using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTrigger : MonoBehaviour
{
    [SerializeField] private bool isNeartoMe;
    [SerializeField] private Animator animator;

    private void Start()
    {
        isNeartoMe = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Corrected this line
        {
            isNeartoMe = true;
            animator.SetBool("isAttacking", isNeartoMe);
            Debug.Log("Attacking, Attacking, Attacking");
        }
    }
}
