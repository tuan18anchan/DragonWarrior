using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Timeline;

public class BulletBehiviour : MonoBehaviour
{
    private float Sp = 3f;

    public Vector3 LauchOb;
    public bool Thrown;
    public float damage;
    public GameObject player;
    private void Start()
    {
        if (Thrown)
        {
            var direction = transform.right + Vector3.up;
            GetComponent<Rigidbody2D>().AddForce(-direction * Sp, ForceMode2D.Impulse);
        }
        transform.Translate(LauchOb);

        Destroy(gameObject, 5);
       
    }

    private void Update()
    {

        if (Thrown)
        {
            transform.position += -transform.right * Time.deltaTime * Sp;
        }

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag.Equals("Player"))
        {
           collision.GetComponent<Playermove>().takedamage(damage);
            Destroy(gameObject);
        }
        
            Destroy(gameObject);
        
    }
   
}
