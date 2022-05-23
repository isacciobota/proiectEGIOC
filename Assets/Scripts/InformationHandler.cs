using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InformationHandler : MonoBehaviour
{
    TMP_Text information;

    void Start() 
    {
        information = GetComponent<TMP_Text>();
        information.enabled = true;    
    }

    void Update()
    {
        if (Input.GetKeyDown("space")){
            information.enabled = !information.enabled;
        }
    }
}
