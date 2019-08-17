using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public GameObject panel;
    public AudioSource explosao;
    public Text placar;
    int pontos;
    string textPontos;

    void Start()
    {
        panel.SetActive(false);
        pontos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(pontos == 1)
        {
            textPontos = " Ponto";
        }
        else
        {
            textPontos = " Pontos";
        }

        placar.text = pontos + textPontos;

        if (transform.position.y < -12f || transform.position.x < -20f || transform.position.y > 20f)
        {
            Destroy(this.gameObject);
            panel.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "flip" && collision.gameObject.tag != "woodside")
        {
            if (collision.gameObject.tag == "stone")
            {
                pontos += 1;
                explosao.Play();
            }

            collision.rigidbody.constraints = new RigidbodyConstraints2D();
            collision.collider.isTrigger = true;
        }
    }
}
