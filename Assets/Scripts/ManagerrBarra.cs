using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ManagerrBarra : MonoBehaviour
{
    public TextMeshProUGUI TextoNumeroMana;
    public Image BarraMana;
    public float VelocityMana;
    public float NumeroActualMana;

    public float ContadorMana;
    private void Awake()
    {
        ContadorMana = 0.6f;
        BarraMana.fillAmount = 0.5f;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    private void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AumentoMana();
    }
    void AumentoMana()
    {
        if (NumeroActualMana <= 10)
        {
            BarraMana.fillAmount += Time.deltaTime * VelocityMana; //Aumento de la barra de Mana
            TextoNumeroMana.text = NumeroActualMana.ToString();

            if (BarraMana.fillAmount > ContadorMana) // Cambia el numero de Mana que se puede usar
            {
                NumeroActualMana++;          
                ContadorMana += 0.10f;

            }



        }
       

    }
}
