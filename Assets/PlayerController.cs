using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float power = 10;
    public Rigidbody rigidbody;
    public GameObject gameOver;
    public GameObject clearTxt;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < -5)
        {
            if (!clearTxt.activeSelf)
            {
                gameOver.SetActive(true);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rigidbody.AddForce(new Vector3(0, 0, 1) * power);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                rigidbody.AddForce(new Vector3(0, 0, -1) * power);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rigidbody.AddForce(new Vector3(-1, 0, 0) * power);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                rigidbody.AddForce(new Vector3(1, 0, 0) * power);
            }
        }
    }
}
