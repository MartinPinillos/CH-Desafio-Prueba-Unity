using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndStreet : MonoBehaviour
{
    float speedEndStreet = 5.00f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveEndStreet(Vector3.forward * 2f);
        //transform.position += new Vector3(0f,0f,2f) * Time.deltaTime * speedEndStreet;
    }
    void MoveEndStreet(Vector3 direction)
    {
        transform.Translate(speedEndStreet * Time.deltaTime * direction);
    }
}
