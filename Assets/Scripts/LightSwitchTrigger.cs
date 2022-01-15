using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightSwitchTrigger : MonoBehaviour
{
    public Text interactText;
    public Light light;
    public bool isInArea;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isInArea) //qd carrega no E e está dentro do trigger do objeto
        {
            light.enabled = !light.enabled;
        }
    }

    //Pode ser chamado se o objeto onde o script está associado tiver um Collider com o isTrigger == true; ver Spot Light na Scene 
    private void OnTriggerEnter(Collider other) //quando entra no trigger
    {
        if (other.tag == "Player")
        {
            isInArea = true;
            interactText.gameObject.SetActive(true);
        }
    }

    //Pode ser chamado se o objeto onde o script está associado tiver um Collider com o isTrigger == true
    private void OnTriggerExit(Collider other) //quando sai do trigger
    {
        if (other.tag == "Player")
        {
            isInArea = false;
            interactText.gameObject.SetActive(false);
        }
    }
}
