using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatsPJ : MonoBehaviour
{

    public int Vida;
    public int Armadura;
    public int Daño;

    public TextMeshProUGUI TextoVida;

    // Start is called before the first frame update
    void Start()
    {
        TextoVida.text = Vida + "/" + Vida; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void UiVida()
    {

    }
}
