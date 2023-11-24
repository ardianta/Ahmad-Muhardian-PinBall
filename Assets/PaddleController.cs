using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode input;
    public float springPower;

    // menyimpan angka target position saat ditekan dan dilepas
    private float targetPressed;
    private float targetRelease;

    private HingeJoint hinge;

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();

        // set kedua target
        targetPressed = hinge.limits.max;
        targetRelease = hinge.limits.min;
    }

    // Update is called once per frame
    void Update()
    {
        ReadInput();
        MovePaddle();
    }

    private void ReadInput()
    {
        // mengambil spring dari component Hinge joint
        JointSpring jointSpring = hinge.spring;

        // mengubah value spring saat input ditekan dan dilepas
        if(Input.GetKey(input))
        {
            Debug.Log("Tombol ditekan!");
            jointSpring.targetPosition = targetPressed;
        }
        else
        {
            jointSpring.targetPosition = targetRelease;
        }

        // update value pada Hinge Joint component
        hinge.spring = jointSpring;
    }

    private void MovePaddle()
    {

    }
}
