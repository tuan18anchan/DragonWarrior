using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerattack : MonoBehaviour
{
    private Animator anim;

    public Transform attackpoint;
    public float attackRange;
    public LayerMask enemyLayers;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            anim.SetTrigger("attack");
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            anim.SetTrigger("xien");
        }
    }
   
    
    private void OnDrawGizmosSelected()
    {
        if (attackpoint == null)
            return;

        Gizmos.DrawWireSphere(attackpoint.position, attackRange);
    }
}
