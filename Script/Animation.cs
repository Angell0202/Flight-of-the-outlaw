using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public GameObject ani;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ani.GetComponent<Animator>().Play("lane");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ani.GetComponent<Animator>().Play("lane");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ani.GetComponent<Animator>().Play("jump");
        }
    }
}
