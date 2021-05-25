using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOf : MonoBehaviour
{
    public Material[] _material;
    public GameObject _light;
    public float startTime = 5;
    public float startResteTime =5;
    bool i = true;
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        startTime -= Time.deltaTime;
        if (startTime <= 0)
        {
           
            if (i == true)
            {
                _light.gameObject.SetActive(false);
               this.gameObject.GetComponent<MeshRenderer>().material = _material[1];
                i = false;
            }
           else if (i == false)
            {
                _light.gameObject.SetActive(true);
                this.gameObject.GetComponent<MeshRenderer>().material = _material[0];
                i = true;
            }
            startTime = startResteTime;
        }
    }

}
