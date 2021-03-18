using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Importē, lai lietotu pointer darbību interfeisu
//Papildus ir jāpārliecinās, ka projektā pie Canvas ir importēta EventSystem UI komponente.
using UnityEngine.EventSystems;

//Piesaista pointer interfeisu
public class ObjektuParvietosana : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform transformacijuLogs;
    public Canvas kanva;

    private void Awake()
    {
        transformacijuLogs = GetComponent<RectTransform>();
    }
    //Funkcija nostrādā, kad uzkliksķināts uz parvietojama objekta
    public void OnPointerDown(PointerEventData notikums)
    {
        Debug.Log("Kreisais klikšķis uz parvietojamā objekta!");
    }
    //Funckija nostrādā uzsākot pārvietošanu
    public void OnBeginDrag(PointerEventData notikums)
    {
        Debug.Log("Uzsakta parvietošana!");
    }

    //Funkcija nostrādā pārvietošanas brīdī
    public void OnDrag(PointerEventData notikums)
    {
        transformacijuLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;
    }

    public void OnEndDrag(PointerEventData notikums)
    {
        Debug.Log("Vilkšana pabeigta!");
    }

}