using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Joystick Joystick;

    float velocidade = 6f;
    Transform jogador;

    float horizontal;
    float vertical;



    // Start is called before the first frame update
    void Start()
    {
        jogador = GameObject.FindWithTag("Player").transform;
        Joystick = GetComponent<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {



        Vector2 movimento = new Vector3(Joystick.Horizontal, 0, Joystick.Vertical);
        movimento = movimento * velocidade * Time.deltaTime;

        movimento *= 1;
        jogador.transform.Translate(movimento);
    }
}

