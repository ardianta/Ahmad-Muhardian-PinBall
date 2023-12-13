using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour
{

    public Collider bola;
    public KeyCode input;
    public float maxTimeHold;
    public float maxForce;
    public float force;

    public Material holdingMaterial;
    public Material idleMaterial; 

    // button holding state
    private bool isHold = false;

    private Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.collider == bola)
        {
            ReadInput(bola);
        }
    }

    private void ReadInput(Collider collider)
    {
        if(Input.GetKey(input) && !isHold)
        {
            StartCoroutine(StartHold(collider));
        }
    }

    private IEnumerator StartHold(Collider collider)
    {
        isHold = true;
        float force = 0.0f;
        float timeHold = 0.0f;

        // set launcher renderer
        renderer.material = holdingMaterial;

        while(Input.GetKey(input))
        {
            // kalkulasi force
            force = Mathf.Lerp(0, maxForce, timeHold / maxTimeHold);

            yield return new WaitForEndOfFrame();
            timeHold += Time.deltaTime;
        }
        
        // move ball
        collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        isHold = false;

        // set launcher render
        renderer.material = idleMaterial;
    }
}
