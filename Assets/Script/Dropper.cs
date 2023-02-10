using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer render;
    Rigidbody rigid; 
    [SerializeField] float timeToWait = 5f;

    void Start()
    {
        render = GetComponent<MeshRenderer>();
        rigid = GetComponent<Rigidbody>();
        render.enabled = false;
        rigid.useGravity = false;
    }

    void Update()
    {
        

        if (Time.time > timeToWait)
        {
            rigid.useGravity = true;
            render.enabled = true;
        }
    }
}
