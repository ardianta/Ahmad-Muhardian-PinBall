using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour
{

    public Collider bola;
    public KeyCode input;
    public float force; 

    // Start is called before the first frame update
    void Start()
    {
        
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
        if(Input.GetKey(input))
        {
            collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force); 
        }
    }
}
