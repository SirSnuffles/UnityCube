using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftScript : MonoBehaviour
{
    private float RotationSensitivity = 150;
    // Start is called before the first frame update
    void Start()
    {
        print("StartingLeftScript");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Alpha2))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * RotationSensitivity);
            print("2 key is held down");
        }
        if (Input.GetKey(KeyCode.F2))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * RotationSensitivity);
            print("f2 key is held down");
        }
    }
}
