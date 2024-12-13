using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    public int Rabbit = 0;
    public int Key = 0;

    public GameObject rabbit;
    public GameObject key;

    public GameObject notebookOpen;
    public GameObject notebookClosed;

    private void Start()
    {
        notebookClosed.SetActive(true);
        notebookOpen.SetActive(false);
    }

    private void Update()
    {
        if(Rabbit == 1)
        {
            rabbit.SetActive(true);
            notebookOpen.SetActive(true);
        } else
        {
            rabbit.SetActive(false);
        }

        if (Key == 1)
        {
            key.SetActive(true);
        }
        else
        {
            key.SetActive(false);
            notebookOpen.SetActive(false);
        }

        if (notebookOpen.activeSelf)
        {
            notebookClosed.SetActive(false);
        }
        else
        {
            notebookClosed.SetActive(true);
        }

        //if (notebookClosed.activeSelf && notebookOpen.activeSelf)
        //{
        //    // If both are active, disable objectB
        //    notebookClosed.SetActive(false);
        //}
        //else if (!notebookClosed.activeSelf && !notebookOpen.activeSelf)
        //{
        //    // If both are inactive, enable objectB
        //    notebookClosed.SetActive(true);
        //}

    }

}
