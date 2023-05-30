using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPost, bulletPost1, bulletPost2;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1) {
            timer = 0;
            shoot();
        }
        
    }
    void shoot()
    {
       
        if (GetComponent<Boss>().health <= 25 && GetComponent<Boss>().health > 0 && Playermove.healthamount > 0)
        {
            Instantiate(bullet, bulletPost.position, Quaternion.identity);
            Instantiate(bullet, bulletPost1.position, Quaternion.identity);
            Instantiate(bullet, bulletPost2.position, Quaternion.identity);
        }
        
    
    }
}
