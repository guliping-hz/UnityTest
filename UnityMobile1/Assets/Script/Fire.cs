using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed = 4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody body = Instantiate(projectile, transform.position, transform.rotation);
            body.velocity = transform.forward * speed;
        }
    }
}
