using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Jaieimporte, lai varetu stradat ar UI elementiem
using UnityEngine.UI;


public class VardaParadisana : MonoBehaviour
{
    //Mainīgajā saglabās tekstu ko raksta teksta laukā
    public string teksts;
    //Mainīgajā saglabās tekstu ko raksta teksta laukā
    public string teksts1;
    //Lauks, kurā ieraksta tekstu
    public GameObject ievadesLauks;
    //Lauks, kurā ieraksta tekstu
    public GameObject ievadesLauks1;
    //Kur attelot tekstu
    public GameObject tekstaAttelosana;

    //Funkcija tiek izsaukta nospiežot pogu
    public void uzglabatTekstu()
    {
        teksts = ievadesLauks.GetComponent<Text>().text;
        teksts1 = ievadesLauks1.GetComponent<Text>().text;
        tekstaAttelosana.GetComponent<Text>().text = "Cilvēku sauc " + teksts + " un viņam/ai ir "+teksts1+ " gadi!";
        ;
    }

}
