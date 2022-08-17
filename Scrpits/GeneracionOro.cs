using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generacionOro : MonoBehaviour
{
    [SerializeField] string proyectil;
    [SerializeField] int damage;
    [SerializeField] int vida;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(proyectil))
        {
            vida = vida - damage;
        }
        if (vida <= 0)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;
            transform.gameObject.tag = "Muerto";
        }
    }
}
