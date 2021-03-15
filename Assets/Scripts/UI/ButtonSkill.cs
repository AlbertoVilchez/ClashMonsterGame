using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSkill : MonoBehaviour
{
    public ObjSkill ThisSkill;
    public TextMeshProUGUI TextoMana;

    [SerializeField]
     Image ImgRecarga;

    // Start is called before the first frame update
    void Start()
    {
        ImgRecarga.fillAmount = 0;
        TextoMana.text = ThisSkill.Nmana.ToString();
        ThisSkill.ImagenRecarga = ImgRecarga;
    }

    // Update is called once per frame
    void Update()
    {

        if (!ThisSkill.TiempoRecarga) // Comprueba si esta activa en el Scriptobj el tiempo para Recargar
        {
            ImgRecarga.fillAmount -= Time.deltaTime * ThisSkill.TimeUse;

            if (ImgRecarga.fillAmount == 0 ) 
            {
                ThisSkill.TiempoRecarga = true;
            }
        }
    }






}
