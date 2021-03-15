using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResourcesManager : MonoBehaviour
{
    [SerializeField]
     int MonedasTotales;
    [SerializeField]
     int GemasTotales;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("Monedas", MonedasTotales);
        PlayerPrefs.SetInt("Gemas", GemasTotales);

        Debug.Log(PlayerPrefs.GetInt("Monedas"));
    }

  
}
