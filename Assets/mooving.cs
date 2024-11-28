using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mooving : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.right * 5f * Time.deltaTime);   
        if(transform.position.x > 25)
        {
            Destroy(gameObject);
        }
    }
}
