using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;

public class Player_tutorial : MonoBehaviour
{
    public Transform freelook;
    public Animator animador;
    public float force;
    public float Jumpforce;
    public Text pontuacao;
    public int pontos;
    private bool canjump;
    public GameObject bola;
    public GameObject monstro;
    public bool powerjump;

    Rigidbody rb;
    float hor;
    float ver;
    Vector3 direction;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animador = GetComponent<Animator>();
        powerjump = false;
    }

    private void Update()
    {
        pontuacao.text = pontos.ToString();

        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump") && canjump && powerjump)
        {
            rb.AddForce(Vector3.up * Jumpforce);
            canjump = false;
        }

    }

    private void FixedUpdate()
    {
        Vector3 camFoward = transform.position - freelook.position;
        camFoward = new Vector3(camFoward.x, 0, camFoward.z).normalized;
        Vector3 camRight = Vector3.Cross(Vector3.up, camFoward).normalized;

        direction = camFoward * ver + camRight * hor;
        rb.AddForce(direction * force);
        if (hor == 0 && ver == 0)
        {
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
            bola.SetActive(false);
            monstro.SetActive(true);
            animador.enabled = false;
            transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
        }
        else
        {
            bola.SetActive(true);
            monstro.SetActive(false);
            animador.enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        TriggerCam tmpTriggerCam;

        if (other.TryGetComponent<TriggerCam>(out tmpTriggerCam))
        {
            GameManager.INSTANCE.ChangeCam(tmpTriggerCam.cam);
        }

        if (other.gameObject.tag == "coletavel")
        {
            other.gameObject.SetActive(false);
            pontos++;
        }

        if (other.gameObject.tag == "power")
        {
            other.gameObject.SetActive(false);
            powerjump = true;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        canjump = true;
    }

}
