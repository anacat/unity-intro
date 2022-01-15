using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DoorController : MonoBehaviour
{
    public Text interactText;
    public Animator animator;
    public AudioSource audioEffect;
    public bool isInArea;
    
    void Start()
    {
        Debug.Log("start");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) == true && isInArea) //qd carrega no E e está dentro do trigger do objeto; ver Door na Scene
        {
            bool doorState = animator.GetBool("isDoorOpen");

            if (doorState)
            {
                animator.SetBool("isDoorOpen", false);
            }
            else
            {
                animator.SetBool("isDoorOpen", true);
            }
            
            audioEffect.Play();
        }
    }

    //Pode ser chamado se o objeto onde o script está associado tiver um Collider com o isTrigger == true
    private void OnTriggerEnter(Collider other) //qd entra no trigger
    {
        if (other.tag == "Player")
        {
            isInArea = true;
            interactText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other) //qd sai do trigger
    {
        if (other.tag == "Player")
        {
            isInArea = false;
            interactText.gameObject.SetActive(false);
        }
    }
}
