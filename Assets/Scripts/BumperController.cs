using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    // menyimpan variabel bola sebagai ref untuk pengecekan
    public Collider bola;
    public float multiplier;
    public Color color;

    private Animator animator;
    private Renderer renderer;

    public AudioManager audioManager;
    public VFXManager vfxManager;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material.color = color;

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider == bola)
        {
            Debug.Log("Kena Bola");
            // ambil rigidbody bola lalu kali kecepatan dengan multiplier
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            // Trigger bumper animation
            animator.SetTrigger("Hit"); // <-- nama trigger case sensitive, cek nama Trigger di Animator

            // kita jalankan SFX saat tabrakan dengan bola pada posisi tabrakannya
            audioManager.PlaySFX(collision.transform.position);

            // play VFX
            vfxManager.PlayVFX(collision.transform.position);
        }
    }

}
