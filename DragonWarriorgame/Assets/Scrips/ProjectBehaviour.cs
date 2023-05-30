using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    private float Sp = -10f;

    public Vector3 LauchOb;
    public bool Thrown;
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
}
