using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ManagerSkill : MonoBehaviour
{
    
    public ManagerrBarra ScriptMana;
    public AudioSource AudiosSkin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonPulse(ObjSkill obj)
    {
        

        if (ScriptMana.NumeroActualMana >= obj.Nmana && obj.TiempoRecarga)
        {
            // Calcula el porcentaje que le resta a la barra de mana en funcion de los puntos que cuesta la Habilidad
 
            float CalculoFraccionMana = obj.Nmana * 10;
            ScriptMana.BarraMana.fillAmount -= CalculoFraccionMana / 100;
            ScriptMana.ContadorMana -= CalculoFraccionMana / 100;
            ScriptMana.NumeroActualMana -= obj.Nmana;

            obj.ImagenRecarga.fillAmount = 1;
            obj.TiempoRecarga = false;           //Desactiva El boton para activar el tiempo de recarga

            AudiosSkin.PlayOneShot(obj.SonidoDisparo);

        }
        
              
    }




}
