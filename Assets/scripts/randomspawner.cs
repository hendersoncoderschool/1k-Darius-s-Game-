using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomspawner : MonoBehaviour
{
    public GameObject target;
    public int score;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnTarget", 1f, 1f);
    }

    void SpawnTarget(){
        Instantiate(target, new Vector3(-12, Random.Range(-9, -6), 0), target.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
