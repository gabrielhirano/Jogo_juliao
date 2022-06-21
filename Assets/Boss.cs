using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{      
    public float speed = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        //transform.position = transform.position + movement * 1 * Time.deltaTime;

        if(Input.GetKey(KeyCode.D)){
            Vector3 movement =new Vector3(1f, 0f ,0f);
            transform.position = transform.position + movement * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A)){
            Vector3 movement =new Vector3(1f, 0f ,0f);
            transform.position = transform.position - movement * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.W)){
            Vector3 movement =new Vector3(0f, 5f ,0f);
            transform.position = transform.position + movement * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S)){
            Vector3 movement =new Vector3(1f, 0f ,0f);
            transform.position = transform.position - movement * speed * Time.deltaTime;
        }
    }
}
