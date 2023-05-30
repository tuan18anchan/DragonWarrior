using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beechase : MonoBehaviour
{
    public float speed;
    public float attackRange;

    Transform player;
    Rigidbody2D rb;
    bee be;
    Vector2 vtrbd;
    Animator anim;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
        be = GetComponent<bee>();
        anim = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {

        be.LookAtPlayer();
        if(Vector2.Distance(player.position, rb.position) <= 4)
        {
            Vector2 target = new Vector2(player.position.x, player.position.y+0.8f);
            transform.position = Vector2.MoveTowards(this.transform.position, target, speed * Time.fixedDeltaTime);
            if (Vector2.Distance(player.position, rb.position) <= attackRange)
            {
                anim.SetTrigger("Attack");
            }
        }
            
        
    }
}
