using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ManagerSkill : MonoBehaviour
{
   
    public ManagerrBarra ScriptMana;
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
        
        if (ScriptMana.NumeroActualMana >= obj.Nmana)
        {

            float CalculoFraccionMana = obj.Nmana * 1;
            ScriptMana.BarraMana.fillAmount -= CalculoFraccionMana / 10;
            ScriptMana.ContadorMana -= CalculoFraccionMana / 10;
            ScriptMana.NumeroActualMana -= obj.Nmana;
     

        }
        
              
    }



}
