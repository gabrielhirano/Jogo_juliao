using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D corpoPersonagem;
    public Transform posicaoDoPe;

    public LayerMask chao;



    public Animator anim;
    public float speed = 3;
    public GameObject meuTiro;

    public Animator disparo;

    float controlerRight = 0.1f;
    float controlerLeft = -0.1f;


    public float velocidade;
    public float forcaDoPulo;

    private float direcao;

    private bool estaNoChao;

    private bool olhandoDireita = true;




    // Start is called before the first frame update
    void Start()
    {

    }
        // 0.1565097  0.1594677
    // Update is called once per frame
    void Update()
    {













        //estaNoChao = Physics2D.OverlapCircle(posicaoDoPe.position,0.3f,chao);
        // anim.SetBool("EstaNoChao",estaNoChao);
        // if((corpoPersonagem.velocity.y < 0.12f) && (corpoPersonagem.velocity.y > 0f)){
        //     Debug.Log(Mathf.Abs(corpoPersonagem.velocity.y));
        // }
        // if((corpoPersonagem.velocity.y < 0.12f) && (corpoPersonagem.velocity.y > 0 )){
        //     anim.SetFloat("Vertical", corpoPersonagem.velocity.y);
        //     anim.SetBool("EstaNoChao", false);
        // }else{
        //     anim.SetBool("EstaNoChao", false);
        //     anim.SetBool("Jumping", false);
        //     // Debug.Log("jumping");
        // }

        //movimentação
        if (Input.GetButtonDown("Fire1")){
            Instantiate(meuTiro, transform.position, transform.rotation);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            controlerRight = 2f;
            Vector3 movement =new Vector3(controlerRight, 0f ,0f);
 
            transform.position = transform.position + movement * speed * Time.deltaTime;
            anim.SetFloat("Horizontal", movement.x);
            anim.SetFloat("Speed", movement.magnitude);
        }
        else if(Input.GetKey(KeyCode.LeftArrow)){
            controlerLeft = -2f;

            Vector3 movement =new Vector3(controlerLeft, 0f ,0f);
            transform.position = (transform.position - (movement*-1) * speed * Time.deltaTime);
            anim.SetFloat("Horizontal", movement.x);
            anim.SetFloat("Speed", movement.magnitude);

        }else if(Input.GetKey(KeyCode.UpArrow)){
            corpoPersonagem.velocity = Vector2.up * forcaDoPulo;
            // Vector3 movement =new Vector3(0f, 6f ,0f);
            // transform.position = transform.position + movement * Time.deltaTime;
            // Debug.Log(transform.position);
        }
        else{
            Vector3 movement =new Vector3(0f, 0f ,0f);
            anim.SetFloat("Horizontal", movement.x);
            anim.SetFloat("Speed", movement.magnitude);
        }
        
        
        controlerRight = 0;
        controlerLeft = 0;
    }
}
