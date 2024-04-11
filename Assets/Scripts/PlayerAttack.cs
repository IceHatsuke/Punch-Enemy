using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public int danoDoAtaque = 1; // Dano causado pelo ataque do jogador
    BossStatus status;

    private void Update()
    {
        if (GameObject.Find("Inimigo") == null)
        {

            return;
            
        }

        if (status == null) 
        {
            status = GameObject.FindWithTag("Inimigo").GetComponent<BossStatus>(); }
        if (Input.GetMouseButtonDown(0)) 
        {
            status.ReceberDano(danoDoAtaque);
        }
    }

}
