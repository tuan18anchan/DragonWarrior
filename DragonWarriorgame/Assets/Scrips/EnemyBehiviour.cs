using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyBehiviour : MonoBehaviour
{
   
    public float tocdo;
    public bool dichuyentrai = true;
    public float damage;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(9,9,true);  
    }
    private void FixedUpdate()
    {
        Vector2 dichuyen = transform.localPosition;
        if (dichuyentrai)
        {
            dichuyen.x -= tocdo * Time.deltaTime;
        }
        else
        {
            dichuyen.x += tocdo * Time.deltaTime;
        }
        transform.localPosition = dichuyen;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "gioihanene")
        {
            quaymat();
            dichuyentrai = !dichuyentrai;
        }
       
    }
    protected void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.CompareTag("Player") && Mathf.Abs(collision.contacts[0].normal.x)==1)
        {
            
            collision.gameObject.GetComponent<Playermove>().takedamage(damage);
            
        }
   }
    
    private void quaymat()
    {
        Vector2 huongmat = transform.localScale;
        huongmat.x *= -1;
        transform.localScale = huongmat;
    }
}
