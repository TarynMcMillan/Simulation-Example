using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    [SerializeField] GameObject introPanel;
    void Start()
    {
        introPanel.SetActive(true);
    }

    void Update()
    {
        
    }
}
