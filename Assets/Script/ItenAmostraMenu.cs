using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItenAmostraMenu : MonoBehaviour
{
    [Header("Iten ativo")]
    public GameObject itenMenu;
    private bool ativo_r = false;

    void Start()
    {
        itenMenu.gameObject.SetActive(false);
       
    }

    void Update()
    {
        if (ativo_r  == true)
        itenMenu.transform.Rotate(0, 0 + 15f * Time.deltaTime, 0);
        
    }

    public void ItenMenuAtivo()
    {
        ativo_r = true;
        itenMenu.gameObject.SetActive(true);
       

    }
    public void ItenMenuDesativo()
    {
        Vector3 zerar =  Vector3.zero;
        itenMenu.gameObject.SetActive(false);
        itenMenu.transform.rotation = this.transform.rotation;
        ativo_r = false;

    }
  

}  
