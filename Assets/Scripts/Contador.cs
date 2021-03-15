using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    float Ncontador;
    public TextMeshProUGUI TextoContador;
    // Start is called before the first frame update
    void Start()
    {
        Ncontador = 60;
    }

    private void FixedUpdate()
    {
        if (Ncontador > 0)
        {
            Ncontador -= Time.deltaTime;
        }
       
    }
    // Update is called once per frame
    void Update()
    {
        TextoContador.text = Ncontador.ToString("f0") ;
    }
}
