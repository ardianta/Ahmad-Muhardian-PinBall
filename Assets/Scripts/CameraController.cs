using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform dummyTarget;
    private Transform target;
    private Vector3 defaultPosition;

    // Start is called before the first frame update
    void Start()
    {
        defaultPosition = transform.position;
        target = null;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            FocusAtTarget(dummyTarget);
        }

        if(Input.GetKey(KeyCode.R))
        {
            GoBackToDefault();
        }
    }

    private void FocusAtTarget(Transform targetTransform)
    {
        target = targetTransform;

        // kalkulasi posisi untuk fokus ke target
        targetTransform.position

        // grakan kamera ke posisi target
        StartCoroutine(MovePosition(targetTransform.position, 5));
    }

    private void GoBackToDefault()
    {
        target = null;

        // gerakan kamera ke posisi semula
        StartCoroutine(MovePosition(defaultPosition, 5));
    }

    private IEnumerator MovePosition(Vector3 target, float time)
    {
        float timer = 0.0f;
        Vector3 start = transform.position;

        while(timer < time)
        {
            // pindahkan posisi camera bertahap
            transform.position = Vector3.Lerp(start, target, Mathf.SmoothStep(0.0f, 1.0f, timer/time));

            timer += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        transform.position = target;
    }
}
