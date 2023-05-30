using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fire : MonoBehaviour
{
    private Animator anim;
    private CircleCollider2D circleCollider;
    void Start()
    {
        anim= GetComponent<Animator>();
        circleCollider= GetComponent<CircleCollider2D>();
        Physics2D.IgnoreLayerCollision(8, 8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        circleCollider.isTrigger= false;
            if (collision.tag.Equals("Enemy"))
            {
            collision.GetComponent<Enemyhurt>().takedamge(1);
            }
        if (collision.tag.Equals("Boss"))
        {
            collision.GetComponent<Boss>().health -= 5;
        }
        anim.SetTrigger("explode");
    }
    private void Deathactive()
    {
        Destroy(gameObject);
    }
}
