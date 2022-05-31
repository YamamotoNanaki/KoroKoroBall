using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public GameObject obj;
    public GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        particle.transform.position = obj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        particle.transform.position = obj.transform.position;
    }
}
