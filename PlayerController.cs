using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Speed;

    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
        //Set the speed of the GameObject
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
        transform.Translate(Vector3.forward * Time.deltaTime *m_Speed *1.5f);
        } else
        {
        transform.Translate(Vector3.forward * Time.deltaTime *m_Speed);
        }
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * 5;
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Rotate the sprite about the Y axis in the positive direction
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * 40, Space.World);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Rotate the sprite about the Y axis in the negative direction
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * 40, Space.World);
        }
    }
}
