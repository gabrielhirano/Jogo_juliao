using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptDoTiro : MonoBehaviour
{

    public float velocidade = 10f;
    public Rigidbody2D meuRB;
    // Start is called before the first frame update
    void Start()
    {
        meuRB.velocity = Vector2.right * velocidade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
