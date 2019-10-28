using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (ControllerScript.airplane == gameObject)
        {
            ControllerScript.airplane.transform.localScale = new Vector3 (1.2f, 1.2f, 1.2f);
            ControllerScript.activeAirplane = gameObject;
            ControllerScript.airplane = null;
        }
        else if (ControllerScript.activeAirplane == gameObject)
        {
            ControllerScript.activeAirplane.transform.localScale = new Vector3(1f, 1f, 1f);
            ControllerScript.airplane = gameObject;
            ControllerScript.activeAirplane = null;
        }
        else if (ControllerScript.activeAirplane != null)
            {
                ControllerScript.activeAirplane.GetComponent<Renderer>().material.color = Color.white; //turns last cube white
                ControllerScript.activeAirplane.transform.localScale = new Vector3(1f, 1f,1f);
                ControllerScript.activeAirplane = gameObject;//sets currently clicked cube to active
                ControllerScript.activeAirplane.GetComponent<Renderer>().material.color = Color.red; 
                ControllerScript.activeAirplane.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        }


    }
}
