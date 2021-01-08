using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public GameManager gameManager;

    public float alturaSalto;
    public float velocidad;
    private Rigidbody2D rigidbody2D;
    private Animator animator;
    private bool salto=false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
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
                salto = true;
                animator.SetBool("estaSaltando", true);
                rigidbody2D.AddForce(new Vector2(0, alturaSalto));
            }
            if(Input.GetKey(KeyCode.RightArrow) ||
            Input.GetKey(KeyCode.D))
            {
                rigidbody2D.AddForce(new Vector2(velocidad, 0));
            }
            if(Input.GetKey(KeyCode.A) ||
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
