using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelePortMove : MonoBehaviour
{

    public Image conometro;
    public GameObject obj;
    bool ativarObj = false;
    float timeStart = 3;

    GameObject player;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        conometro.fillAmount = timeStart;
    }
   

    private void Update()
    {
        float t = Time.deltaTime;
        conometro.fillAmount = timeStart;
        if (ativarObj == true)
        {           
            timeStart -= t;
            obj.gameObject.SetActive(true);
        }
        if (conometro.fillAmount <= 0)
        {
            player.transform.position = this.transform.position - new Vector3(0, 0.1f, 0);
            player.transform.forward = this.transform.forward;
            ativarObj = false;
            obj.gameObject.SetActive(false);
            timeStart = 3;
        }
    }

    public void TeleportPlayer()
    {
        ativarObj = true;
        
    }
    public void NoTeletranporte()
    {
        obj.gameObject.SetActive(false);
        ativarObj = false;
        timeStart = 3;
    }


}
