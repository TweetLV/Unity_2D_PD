using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour
{
    //Uzglabās mūsu bildes no ainas
    public GameObject bikses2;
    public GameObject krekls1;
    public GameObject krekls2;
    public GameObject bikses1;
    public GameObject sKrekls2;
    public GameObject sKrekls1;
    public GameObject svarki;
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject slaiderisx;
    public GameObject slaiderisy;
    public AudioSource skanasAvots;
    public AudioClip skanaKoAtskanot;
    public void sKrekls2Attelosana(bool vertiba)
    {
        sKrekls2.SetActive(vertiba);
    }
    public void sKrekls1Attelosana(bool vertiba)
    {
        sKrekls1.SetActive(vertiba);
    }
    public void svarkiAttelosana(bool vertiba)
    {
        svarki.SetActive(vertiba);
    }
    public void bikses2Attelosana(bool vertiba)
    {
        bikses2.SetActive(vertiba);
    }
    public void krekls1Attelosana(bool vertiba)
    {
        krekls1.SetActive(vertiba);
    }
    public void krekls2Attelosana(bool vertiba)
    {
        krekls2.SetActive(vertiba);
    }
    public void bikses1Attelosana(bool vertiba)
    {
        bikses1.SetActive(vertiba);
    }

    public void izkritosais(int skaitlis)
    {
        if (skaitlis == 0)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
        }
        else if (skaitlis == 1)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
        }

    }

    public void mainitLielumuX()
    {
        float pasreizejaVertiba1 = slaiderisy.GetComponent<Slider>().value;
        float pasreizejaVertiba = slaiderisx.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F*pasreizejaVertiba1);
   
    }
    public void mainitLielumuY()
    {
        float pasreizejaVertiba = slaiderisx.GetComponent<Slider>().value;
        float pasreizejaVertiba1 = slaiderisy.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector2(1F*pasreizejaVertiba , 1F * pasreizejaVertiba1);
    }
    public void uzbiditUzAttela()
    {
        skanasAvots.PlayOneShot(skanaKoAtskanot);
    }
    public void kursorsNobiditsNoAttela()
    {
        skanasAvots.Stop();
    }
}
