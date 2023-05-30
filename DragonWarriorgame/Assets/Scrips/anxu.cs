using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anxu : MonoBehaviour
{
    
    
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && this.tag == "chuoi")
        {
            Scoretext.scoreamount += 100;
            Destroy(gameObject);
        }
        else if (collision.tag == "Player" && this.tag == "kiwi")
        {
            Scoretext.scoreamount += 50;
            Destroy(gameObject);
        }
        else if (collision.tag == "Player" && this.tag == "tao")
        {
            collision.GetComponent<Playermove>().takedhealth(10);
            Destroy(gameObject);
        }
        
    }
}
