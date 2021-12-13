using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnajer : MonoBehaviour
{
    public GameObject obstaculo;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(obstaculo, spawnPos, obstaculo.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
