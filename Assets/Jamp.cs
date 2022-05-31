using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jamp : MonoBehaviour
{
    public float power = 8;
    public Vector3 angle = new Vector3(0, 1, 0);

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody r = other.GetComponent<Rigidbody>();
        if (r != null)
        {
            r.velocity = angle.normalized * power;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
