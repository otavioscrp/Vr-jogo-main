using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtivaMenus : MonoBehaviour
{
    private bool ativaracao = false;
    public GameObject cronometro;
    public Image i;
    private float timevalor =5;

    private int valor = 0;
    private void Start()
    {
        i.fillAmount = timevalor;
    }

    private void Update()
    {
        i.fillAmount = timevalor;

        if(ativaracao == true)
        {
            timevalor -= Time.deltaTime;
        }
        if (i.fillAmount <= 0)
        {
            if (valor == 0)
            {
                GameManager.gm.CarregarCenas("Menu");
            }
            else if (valor == 1)
            {
                GameManager.gm.Sair();
            }
            
        }
       
    }
    public void Ativa( int vl)
    {
        ativaracao = true;
        valor = vl;
        cronometro.SetActive(true);
           
    }
    public void Desativa()
    {
        cronometro.SetActive(false);
        timevalor = 5;
        ativaracao = false;
    }
  
}
