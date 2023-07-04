using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int cherryCount = 0;
    [SerializeField] private Text cherriesText;
    [SerializeField] private AudioSource collectionEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectionEffect.Play();
            Destroy(collision.gameObject);
            cherryCount++;
            cherriesText.text = "Cherries: " + cherryCount;
        }
    }
}
