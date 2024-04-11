using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Score : MonoBehaviour
{

    public Transform prefabInimigo;
    public static float pontos = 0;
    public static float moeda = 0;
    public TextMeshProUGUI score;
    public TextMeshProUGUI moedas;

    private void Update()
    {
        score.text = pontos.ToString();
        moedas.text = moeda.ToString();
    }

    public void IniciaRespawnInimigo()
    {
        Invoke("RespawnInimigo", 1);
    }

    public void RespawnInimigo()
    {
        Transform spawn = Instantiate(prefabInimigo);
        spawn.gameObject.name = "Inimigo";
        GameObject.Find("Canvas").transform.Find("BgLifeBAR").GetComponent<LifeBarStatus>().EncherVida();
    }

}
