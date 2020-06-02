using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour

{


    private void Start()
    {
        Invoke("HideTooltip", 5f);
    }
   

    private void HideTooltip()
    {
        gameObject.SetActive(false);
    }

   
}
