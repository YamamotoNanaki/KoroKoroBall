using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject clearText;
    public GameObject nextButton;
    public GameObject maxCoin;
    public GameObject particle;
    public AudioSource audioSE;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("ÉSÅ[ÉãÅI");

            clearText.SetActive(true);
            nextButton.SetActive(true);
            maxCoin.SetActive(true);
            particle.SetActive(true);
            audioSE.Play();
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
