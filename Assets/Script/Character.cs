using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private float Speed = 2;

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Translate(transform.right * Speed * Time.deltaTime * Input.GetAxis("Horizontal"));
        }   
    }
}
