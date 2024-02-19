using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + transform.forward, speed*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S)) 
        {
            transform.position = Vector3.Lerp(transform.position, transform.position - transform.forward, speed*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D)) 
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + transform.right, speed*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A)) 
        {
            transform.position = Vector3.Lerp(transform.position, transform.position - transform.right, speed*Time.deltaTime);
        }
    }
}
