using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInputToRotate : MonoBehaviour
{
    public LeftScript LeftSlice;

    private float RotationSensitivity = 150;

    // Start is called before the first frame update
    void Start()
    {
        print("Starting input script");
    }

    // Update is called once per frame
    void Update()
    {
        //rotate whole cube for vision

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * RotationSensitivity);
            print("Up arrow key is held down");
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * RotationSensitivity);
            print("Down arrow key is held down");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.left * Time.deltaTime * RotationSensitivity);
            print("Left arrow key is held down");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.right * Time.deltaTime * RotationSensitivity);
            print("Right arrow key is held down");
        }




        if (Input.GetKey(KeyCode.Alpha2))
        {
            print("2 key is held down");
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            print("3 key is held down");

        if (Input.GetKey(KeyCode.Alpha4))
        { 
            print("4 key is held down");
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            print("5 key is held down");
        }
   
        if (Input.GetKey(KeyCode.Alpha6))
        {
            print("6 key is held down");
        }
        if (Input.GetKey(KeyCode.Alpha7))
        {
            print("7 key is held down");
        }

        if (Input.GetKey(KeyCode.Alpha8))
        {
            print("8 key is held down");
        }
        if (Input.GetKey(KeyCode.Alpha9))
        {
            print("9 key is held down");
        }

        if (Input.GetKey(KeyCode.Alpha0))
        {
           print("0 key is held down");
        }
        }
    }
}