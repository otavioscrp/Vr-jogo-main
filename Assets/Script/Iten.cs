using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Iten : MonoBehaviour
{
    public Image conometro;
    public GameObject obj;
    public GameObject itenMenu,itenDoIten;
    private bool ativarObj = false;
    private float timeStartiten= 5;
    private bool ativaAnalizarIten = true;



    private void Start()
    {     
        conometro.fillAmount = timeStartiten;
        itenMenu.SetActive(false);
        itenDoIten.SetActive(false);
    }


    private void Update()
    {
        float t = Time.deltaTime;
        

        if (ativarObj == true)
        {
            conometro.fillAmount = timeStartiten;
            timeStartiten -= t;
            obj.gameObject.SetActive(true);
        }
        if (conometro.fillAmount <= 0)
        {          
            
            obj.gameObject.SetActive(false);
            itenMenu.SetActive(true);
            itenDoIten.SetActive(true);
            ativarObj = false;
            ativaAnalizarIten = false;
        }
    }

    public void PegandoIten()
    {
        if(ativaAnalizarIten == true)
        ativarObj = true;

    }
    public void NOPegandoIten()
    {
       
        obj.gameObject.SetActive(false);
        ativarObj = false;
        timeStartiten = 5;
    }
}
