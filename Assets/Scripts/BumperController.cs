using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    // menyimpan variabel bola sebagai ref untuk pengecekan
    public Collider bola;
    public float multiplier;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider == bola)
        {
            Debug.Log("Kena Bola");
            // ambil rigidbody bola lalu kali kecepatan dengan multiplier
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}