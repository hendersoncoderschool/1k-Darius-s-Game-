using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class howbout : MonoBehaviour
{
    public randomspawner spawner;
    // Start is called before the first frame update
    void Start()
    {
        spawner = GameObject.Find("spawner").GetComponent<randomspawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hoop")){
            print("SCORE");
            Destroy(collision.gameObject.transform.parent.gameObject);
            Destroy(gameObject);
            spawner.score++;
            print(spawner.score);
        }
    }
}
