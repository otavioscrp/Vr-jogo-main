using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager gm;


    bool ativo = true;
    public Image[] menus;
  
   

    private void Awake()
    {
        if(gm == null)
        {
            gm = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }


    public void MenuAtivo(GameObject menu)
    {
        if(ativo == true) 
        {
            menu.gameObject.SetActive(true);
            menus[1].color = Color.green;
            ativo = false;
        }
       else if (ativo == false)
        {
            menu.gameObject.SetActive(false);
            menus[1].color = Color.gray;
            ativo = true;
        }
    }
    public void InvetarioAtivo(GameObject menu)
    {
        if (ativo == true)
        {
            menu.gameObject.SetActive(true);
            menus[0].color = Color.green;
            ativo = false;
        }
        else if (ativo == false)
        {
            menu.gameObject.SetActive(false);
            menus[0].color = Color.gray;
            ativo = true;
        }
    }

    public void CarregarCenas(string scene)
    {
             
         SceneManager.LoadScene(scene);
        
    }

    
    public void Sair()
    {
      
            Application.Quit();
      
    }
 
  
}
