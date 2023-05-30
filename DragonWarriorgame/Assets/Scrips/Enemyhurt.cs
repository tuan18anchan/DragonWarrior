using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyhurt : MonoBehaviour
{
    public float hitpoint;
    public float maxhitpoints = 5;
    public Heathbar heathbar;
    private Animator animator;
    void Start()
    {
        hitpoint = maxhitpoints;
        heathbar.Setheathbar(hitpoint, maxhitpoints);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void takedamge(float damage)
    {
        animator.SetTrigger("hit");
        hitpoint -= damage;
        if (hitpoint <= 0)
        {
            Destroy(gameObject);
        }
        heathbar.Setheathbar(hitpoint, maxhitpoints);

    }
}
