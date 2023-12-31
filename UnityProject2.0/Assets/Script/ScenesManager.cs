using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene_OnKeyPress : MonoBehaviour
{
    [SerializeField] private string scenename;
    [SerializeField] private GameObject uiElement;


    private void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            uiElement.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(scenename);
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiElement.SetActive(false);
        }
    }





}