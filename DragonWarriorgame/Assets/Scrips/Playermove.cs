using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Playermove : MonoBehaviour
{
    [SerializeField] private float speed=2;
    private Rigidbody2D body;
    private Animator anim;
    private bool grounded;
    public ProjectBehaviour projectBehaviour;
    public Transform LaunchOffset;
    public Image healthbar;
    public static float healthamount=100f;
    private float maxhealth;
    private Renderer rend;
    private Color c;
    private Gameover gameover;
    public GameObject pausemenu;
    public float lucnhay=6;
    private void Awake()
    {
        //Grabs references for rigidbody and animator from game object.
        gameover=FindObjectOfType<Gameover>();
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rend = GetComponent<Renderer>();
        c = rend.material.color;
        maxhealth=100f;
        healthbar.fillAmount = healthamount / maxhealth;
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        //Flip player when facing left/right.
        if (horizontalInput > 0.01f)
        {
            //transform.localScale = Vector3.one;
            transform.rotation = Quaternion.identity;
        }
            
        else if (horizontalInput < -0.01f)
        {
            //transform.localScale = new Vector3(-1, 1, 1);
            transform.rotation = Quaternion.Euler(0,180,0);
        }
           

        if (Input.GetKey(KeyCode.UpArrow) && grounded)
            Jump();

        //sets animation parameters
        anim.SetBool("run", horizontalInput != 0);
        anim.SetBool("grounded", grounded);
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(projectBehaviour, LaunchOffset.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            pausemenu.SetActive(true);
            Time.timeScale = 0f;
        }
        if (healthamount <= 0)
        {
            healthamount = 0;
            gameover.gameover();
             gameObject.SetActive(false);
        }
    }
    
    public void takedamage(float dam)
    {   playerdau();
        healthamount -= dam;
        healthbar.fillAmount = healthamount / maxhealth;
       
    }
    public void takedhealth(float hea)
    { 
        if(healthamount < maxhealth)
        {
        healthamount += hea;
        healthbar.fillAmount = healthamount / maxhealth;
        }
        

    }
    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, lucnhay);
        anim.SetTrigger("jump");
        grounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            grounded = true;
    }
    public void playerdau()
    {
        anim.SetTrigger("dau");
        StartCoroutine(gethurt());
    }
    IEnumerator gethurt()
    {
        Physics2D.IgnoreLayerCollision(7, 9, true);
        c.a = 0.5f;
        rend.material.color = c;

        yield return new WaitForSeconds(4f);
        Physics2D.IgnoreLayerCollision(7, 9, false);
        c.a = 1f;
        rend.material.color = c;
    }
}
