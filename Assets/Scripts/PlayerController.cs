using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

  public CharacterController controller;
  public float speed = 12f;

  AudioSource audioSource;
  public AudioClip droneMusic;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }


        float x = Input.GetAxis ("Horizontal");
        float z = Input.GetAxis ("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MusicPlayer")
        {
            audioSource.clip = droneMusic;
            audioSource.Play();
            Destroy(other.gameObject, 1);
        }
    }
}