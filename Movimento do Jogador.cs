using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentodoJogador : MonoBehaviour
{
//Player Moviment
    public float velocidadeDoJogador;

    public Rigidbody2D oRigidbody2D;
//Player Jump 
    public float alturaDoPulo;

    public SpriteRenderer oSpriteRenderer;

    public bool estaNoChao;
    public Transform verificadorDeChao;
    public float raioDeverificacao;
    public LayerMask layerDoChao;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        MovimentardoJogador();
        Pular();
    }
//Player Moviment
    public void MovimentardoJogador()
    {
        float inputDomovimento = Input.GetAxisRaw("Horizontal");
        oRigidbody2D.velocity = new Vector2(inputDomovimento * velocidadeDoJogador, oRigidbody2D.velocity.y);

        if(inputDomovimento > 0)
        {
            oSpriteRenderer.flipX = false;
        }

        if(inputDomovimento < 0)
        {
            oSpriteRenderer.flipX = true;
        }
    }
//Player Jump
    public void Pular()
    {
        estaNoChao = Physics2D.OverlapCircle(verificadorDeChao.position, raioDeverificacao, layerDoChao);
        if(Input.GetKeyDown(KeyCode.Space) && estaNoChao == true)
        {
            oRigidbody2D.velocity = Vector2.up * alturaDoPulo;
        }
    }
}
