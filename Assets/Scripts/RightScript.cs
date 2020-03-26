using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightScript : MonoBehaviour
{
    private float RotationSensitivity = 150;
    // Start is called before the first frame update
    void Start()
    {
        print("StartingRightScript");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Alpha1))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * RotationSensitivity);
            print("1 key is held down");
        }
        if (Input.GetKey(KeyCode.F1))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * RotationSensitivity);
            print("f1 key is held down");
        }
    }
}
