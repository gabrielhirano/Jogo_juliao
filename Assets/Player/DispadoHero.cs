using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispadoHero : MonoBehaviour
{
    public float speed = 15f;
    public Rigidbody2D disparoRB;
    // Start is called before the first frame update
    void Start()
    {
        disparoRB.velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
