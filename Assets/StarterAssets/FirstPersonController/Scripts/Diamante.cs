using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamante : MonoBehaviour
{
    //public Puntos puntos;
    // Start is called before the first frame update
    void Start()
    {
       // puntos = GameObject.FindGameObjectWithTag("Player").GetComponent<Puntos>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player");
        {
            Puntos.Cantidad = Puntos.Cantidad + 10000;
            Destroy(this.gameObject);
        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
