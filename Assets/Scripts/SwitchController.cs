using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{

    public Collider bola;
    public Material offMaterial;
    public Material onMaterial;

    private bool isOn;
    private Renderer renderer;

    private enum SwitchState
    {
        Off,
        On,
        Blink
    }

    private SwitchState state;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        SetSwitch(false);
        
        StartCoroutine(BlinkTimerStart(5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other == bola)
        {
            Toggle();
        }
    }

    private void SetSwitch(bool active)
    {
        if(active)
        {
            state = SwitchState.On;
            renderer.material = onMaterial;
            StopAllCoroutines();
        }
        else
        {
            state = SwitchState.Off;
            renderer.material = offMaterial;
            StartCoroutine(BlinkTimerStart(5));
        }

        Debug.Log(state);
    }

    private void Toggle()
    {
        if(state == SwitchState.On)
        {
            SetSwitch(false);
        }
        else
        {
            SetSwitch(true);
        }
    }

    private IEnumerator Blink(int times)
    {
        state = SwitchState.Blink;

        for (int i = 0; i < times; i++)
        {
            renderer.material = onMaterial;
            yield return new WaitForSeconds(0.2f);
            renderer.material = offMaterial;
            yield return new WaitForSeconds(0.2f);
        }

        state = SwitchState.Off;
        StartCoroutine(BlinkTimerStart(5));
    }

    private IEnumerator BlinkTimerStart(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }
}
