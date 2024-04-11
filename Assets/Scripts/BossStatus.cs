using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossStatus : MonoBehaviour
{
    float vidaBase = 10;
    public static float vidaAtual;
    public static float vidaTotal;
    private Animator animator;
    
    void Start()
    {

        vidaBase = vidaBase * (Score.pontos / 100 + 1);

        vidaAtual = vidaBase; 
        vidaTotal = vidaBase;
        animator = GetComponent<Animator>();

        
    }

    public void ReceberDano(int dano) 
    {
        vidaAtual -= dano;
        GameObject.Find("Canvas").transform.Find("BgLifeBAR").GetComponent<LifeBarStatus>().AtualizaVida();
        VerificarMorte();

    }
    void VerificarMorte() 
    {
        if (vidaAtual <= 0) 
        {
            animator.SetBool("estaMorto", true);
            Invoke("Morte", 1f);
        }
    }
    void Morte() 
    {
        Score.pontos += 15;
        Score.moeda += 5;
        GameObject.Find("ScorePontos").GetComponent<Score>().IniciaRespawnInimigo();
        Destroy(gameObject);
    }




}
