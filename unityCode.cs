using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unityCode : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision other) {
        Debug.Log("carpisti");
    }

    private void OnCollisionStay(Collision other) {
        Debug.Log("carpısma devam ediyor");    
    }

    private void OnCollisionExit(Collision other) {


        if(other.gameObject.name == "Cube2"){

            other.gameObject.GetComponent<MeshRenderer>().enabled= false;

        }
    }


}
