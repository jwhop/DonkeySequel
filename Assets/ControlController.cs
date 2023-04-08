using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlController : MonoBehaviour
{
    Gamepad gamepad1;
    // Start is called before the first frame update
    void Start()
    {
        print(Gamepad.all);
        gamepad1 = Gamepad.all[0];
    }

    // Update is called once per frame
    void Update()
    {
        int leftArrow = 0;
        int rightArrow = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            leftArrow = 1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rightArrow = 1;
        }
        gamepad1.SetMotorSpeeds(leftArrow * 10, rightArrow * 10);
        
    }
}
