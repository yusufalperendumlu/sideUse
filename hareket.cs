using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 hareketYonleri;
        int hiz = 5;
        hareketYonleri = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(-hareketYonleri.x * hiz * Time.deltaTime, 0, -hareketYonleri.z * hiz * Time.deltaTime);
    }
}
