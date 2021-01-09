using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public GameManager gameManager;

    public GameObject jugador;
    public float alturaSalto;
    public float velocidad;
    private Rigidbody2D rigidbody2D;
    private Animator animator;
    private FixedJoint2D fixedJoint2D;
    private AudioSource jump;
    private bool salto=false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        fixedJoint2D = GetComponent<FixedJoint2D>();
        jump = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.start)
        {
            if(!salto && 
            (Input.GetKeyDown(KeyCode.Space) ||
            Input.GetKeyDown(KeyCode.UpArrow) ||
            Input.GetKeyDown(KeyCode.W)))
            {
                jump.Play();
                salto = true;
                animator.SetBool("estaSaltando", true);
                rigidbody2D.AddForce(new Vector2(0, alturaSalto));
            }
            else if(Input.GetKey(KeyCode.RightArrow) ||
            Input.GetKey(KeyCode.D))
            {
                rigidbody2D.AddForce(new Vector2(velocidad, 0));
            }
            else if(Input.GetKey(KeyCode.A) ||
            Input.GetKey(KeyCode.LeftArrow))
            {
                rigidbody2D.AddForce(new Vector2(-1*velocidad, 0));
            }
        }
        if (gameManager.gameOver)
        {
            Destroy(gameObject);
        }
    }

    public void Spawn()
    {
        jugador = Instantiate(JugadorStorage.jugadorPrefab, this.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        fixedJoint2D.connectedBody = jugador.GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Suelo")
        {
            salto = false;
            animator.SetBool("estaSaltando", false);
        }

        if (collision.gameObject.tag == "Obstaculo")
        {
            
            gameManager.gameOver = true;
        }
    }
}
