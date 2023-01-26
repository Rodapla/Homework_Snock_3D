using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource cube;
    public AudioSource point;

    private void Start()
    {
        cube = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube 1")
        {
            cube.Play();
        }

        if (collision.gameObject.tag == "Point 1")
        {
            point.Play();
        }
    }
}
