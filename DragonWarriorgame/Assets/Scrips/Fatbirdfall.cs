using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fatbirdfall : MonoBehaviour
{
    public float damage;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.contacts[0].collider.tag.Equals("Player") && collision.contacts[0].normal.y <= 1)
        {
            collision.gameObject.GetComponent<Playermove>().takedamage(damage);
        }
    }
}
