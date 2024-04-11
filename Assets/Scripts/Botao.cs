using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botao : MonoBehaviour
{

    public GameObject painel;

    public void BotaoFechar()
    {
        painel.SetActive(false);

    }
    public void BotaoAbrir()
    {
        painel.SetActive(true);
    }

   
}
