using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonSkill : MonoBehaviour
{
    public ObjSkill ThisSkill;
    public TextMeshProUGUI TextoMana;
    // Start is called before the first frame update
    void Start()
    {
        TextoMana.text = ThisSkill.Nmana.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }




}
