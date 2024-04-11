using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBarStatus : MonoBehaviour
{
    public Image LifeBar;

    // Update is called once per frame
    public void AtualizaVida()
    {
        float fillAmount = BossStatus.vidaAtual / BossStatus.vidaTotal;
        LifeBar.fillAmount = fillAmount;
    }

    public void EncherVida()
    {
        LifeBar.fillAmount = 100;
    }
}
