using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LePookie : MonoBehaviour
{
    public GameObject basketball;
    private Rigidbody rb;
    public float JumpForce;
    private bool grounded = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        grounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")&& grounded)
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            grounded = false;

        }
        if (Input.GetKeyDown("f"))
        {
         
            GameObject ball = Instantiate(basketball, transform.position + new Vector3(-0.8f, 2f, 0f), Quaternion.Euler(new Vector3(0f,0f,-20f)));
            ball.GetComponent<Rigidbody>().AddForce(ball.transform.right * -1050f);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("lebron")){        
            grounded = true;
        }
        


    }
}
