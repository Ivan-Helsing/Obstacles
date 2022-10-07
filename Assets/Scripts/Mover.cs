using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float speed;

    void Start()
    {
    }

    void Update()
    {
        float xValue = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        float zValue = speed * Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(xValue, 0f, zValue);
    }
}
