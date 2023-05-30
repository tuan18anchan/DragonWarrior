using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantEnemy : MonoBehaviour
{
    public float bd ;
    public float td;
    private Animator anim;
    public BulletBehiviour projectBehaviour;
    public Transform LaunchOffset;
   
    
    void Start()
    {
       
        bd = 0;
        anim = GetComponent<Animator>();
        Physics2D.IgnoreLayerCollision(9, 9, true);
    }

    // Update is called once per frame
    void Update()
    {
        bd += 1*Time.deltaTime;
        if (bd > td)
        {
            anim.SetTrigger("plantattack");
            bd = 0;

        }
    }
    
    public void bandan()
    {
        Instantiate(projectBehaviour, LaunchOffset.position, transform.rotation);
    }
}
