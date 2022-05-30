using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IgnoreRaycastofTarnsparent : MonoBehaviour
{


    private void OnEnable()
    {
        if (this.gameObject.GetComponent<Image>())
        {
            this.gameObject.GetComponent<Image>().alphaHitTestMinimumThreshold = 0.0001f;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TargetButtonClick()
    {
        Debug.Log("Its Clicked!!");
    }
}
