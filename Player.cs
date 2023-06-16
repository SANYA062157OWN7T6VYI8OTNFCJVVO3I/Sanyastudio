using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 newPosition = transform.position;
            newPosition.x += speed * Time.deltaTime;
            transform.position = newPosition;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 newnazadPosition = transform.position;
            newnazadPosition.x -= speed * Time.deltaTime;
            transform.position = newnazadPosition;
        }

    }
}
