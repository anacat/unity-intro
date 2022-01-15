using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightSwitch : MonoBehaviour
{
    public Text interactiveText;
    public Camera mainCamera;
    public Light light;

    public float distanceToCamera;
    public float minDistance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Antigo sistema de inputs
    void Update()
    {
        //a luz só é ligada quando é atingida uma distancia minima pelo jogador
        distanceToCamera = Vector3.Distance(transform.position, mainCamera.transform.position);

        if (distanceToCamera < minDistance)
        {
            interactiveText.gameObject.SetActive(true);
        }
        else
        {
            interactiveText.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E) && distanceToCamera < minDistance)
        {
            light.enabled = !light.enabled;

            /*if (light.enabled == true)
            {
                light.enabled = false;
            }
            else
            {
                light.enabled = true;
            }*/
        }

        if (Input.GetKeyDown(KeyCode.F) && distanceToCamera < minDistance)
        {
            light.intensity += 1;
        }
    }

    /* Novo sistema de inputs
    void FixedUpdate()
    {
        if (Keyboard.current[Key.E].wasPressedThisFrame)
        {
            light.enabled = !light.enabled;

            if (light.enabled == true)
            {
                light.enabled = false;
            }
            else
            {
                light.enabled = true;
            }
        }*/
}