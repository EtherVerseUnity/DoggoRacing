using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPanel : MonoBehaviour
{
    public GameObject YouWinPanel;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Animal")
        {
            YouWinPanel.SetActive(true);
        }
    }

}
