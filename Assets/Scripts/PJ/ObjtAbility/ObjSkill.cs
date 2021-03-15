using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "SkillBase",menuName = "Skill")]
public class ObjSkill : ScriptableObject
{
    public int Nmana;
    public int damage;
    public float TimeUse;
    public bool TiempoRecarga = true;
    public Image ImagenRecarga;
    public AudioClip SonidoDisparo;
}
