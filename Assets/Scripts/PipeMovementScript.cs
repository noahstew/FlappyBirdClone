using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovementScript : MonoBehaviour
{
    private float moveSpeed = 8;
    private float deadzone = -40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BirdScript.birdIsAlive)
        {
            transform.position = transform.position + Vector3.left * moveSpeed * Time.deltaTime;
            if (transform.position.x < deadzone)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }
}
