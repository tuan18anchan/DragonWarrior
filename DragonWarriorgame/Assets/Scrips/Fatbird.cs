using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fatbird : MonoBehaviour
{
    private Rigidbody2D rd;
    private Animator anim;
    private GameObject player;
    public GameObject bird;
    // Start is called before the first frame update
    void Start()
    {
        rd=GetComponent<Rigidbody2D>();
        anim=GetComponent<Animator>();
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.localPosition.x- player.transform.localPosition.x) <= 0.8)
        {
            
            anim.SetBool("fall",true);
            Destroy(gameObject);
            Instantiate(bird,transform.position,transform.localRotation);
        }
    }
}
