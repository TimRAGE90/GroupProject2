using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScientistMove : MonoBehaviour
{

    public GameObject scientist1;
    public GameObject scientist2;
    public GameObject scientist3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Move();
        }
    }

    public void Move()
    {
        scientist1.SetActive(true);
        scientist2.SetActive(true);
        scientist3.SetActive(true);
    }
}
