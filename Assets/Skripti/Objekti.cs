using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject b2;
	public GameObject CementaMasina;
	public GameObject e46;
	public GameObject e61;
	public GameObject Eskavators;
	public GameObject policija;
	public GameObject Traktors1;
	public GameObject Traktors5;
	public GameObject Ugunsdzeseji;
	[HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atrPKoord;
	[HideInInspector]
	public Vector2 bussKoord;
	[HideInInspector]
	public Vector2 b2Koord;
	[HideInInspector]
	public Vector2 CemKoord;
	[HideInInspector]
	public Vector2 e46Koord;
	[HideInInspector]
	public Vector2 e61Koord;
	[HideInInspector]
	public Vector2 EskKoord;
	[HideInInspector]
	public Vector2 polKoord;
	[HideInInspector]
	public Vector2 Trak1Koord;
	[HideInInspector]
	public Vector2 Trak5Koord;
	[HideInInspector]
	public Vector2 UgunsKoord;

	public Canvas kanva;

	public AudioSource skanasAvots;
	public AudioClip[] skanasKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;

	public GameObject pedejaisVilktais = null;


	void Start() {
		atkrMKoord =
        atkritumuMasina.GetComponent<RectTransform>().localPosition;
        
		atrPKoord =
        atraPalidziba.GetComponent<RectTransform>().localPosition;

        bussKoord =
		autobuss.GetComponent<RectTransform>().localPosition;

		b2Koord =
			b2.GetComponent<RectTransform>().localPosition;

		CemKoord = CementaMasina.GetComponent<RectTransform>().localPosition;
		e46Koord = e46.GetComponent<RectTransform>().localPosition;
		e61Koord = e61.GetComponent<RectTransform>().localPosition;
		EskKoord = Eskavators.GetComponent<RectTransform>().localPosition;
		polKoord = policija.GetComponent<RectTransform>().localPosition;
		Trak1Koord = Traktors1.GetComponent<RectTransform>().localPosition;
		Trak5Koord = Traktors5.GetComponent<RectTransform>().localPosition;
		UgunsKoord = Ugunsdzeseji.GetComponent<RectTransform>().localPosition;
    }
}
