using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public bool vaiIstajaVieta = false;
	public GameObject pedejaisVilktais;
	public int totalcars;
	public int carsInPlace = 0;
	public List<GameObject> cars;
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

	private Vector2[] startPositions; // Массив для хранения начальных позиций машинок

	void Start() {
		// Получаем начальные позиции машинок
		startPositions = new Vector2[] {
			atkritumuMasina.GetComponent<RectTransform>().localPosition,
			atraPalidziba.GetComponent<RectTransform>().localPosition,
			autobuss.GetComponent<RectTransform>().localPosition,
			b2.GetComponent<RectTransform>().localPosition,
			CementaMasina.GetComponent<RectTransform>().localPosition,
			e46.GetComponent<RectTransform>().localPosition,
			e61.GetComponent<RectTransform>().localPosition,
			Eskavators.GetComponent<RectTransform>().localPosition,
			policija.GetComponent<RectTransform>().localPosition,
			Traktors1.GetComponent<RectTransform>().localPosition,
			Traktors5.GetComponent<RectTransform>().localPosition,
			Ugunsdzeseji.GetComponent<RectTransform>().localPosition
		};
	}

	// Метод для перемещения машинок на свои места
	public void ResetCars() {
		for (int i = 0; i < startPositions.Length; i++) {
			GameObject car = GetCarAtIndex(i);
			if (car != null) {
				car.GetComponent<RectTransform>().localPosition = startPositions[i];
			}
		}
	}

	// Вспомогательный метод для получения машинки по индексу
	private GameObject GetCarAtIndex(int index) {
		switch (index) {
		case 1:
			return atkritumuMasina;
		case 2:
			return atraPalidziba;
		case 3:
			return autobuss;
		case 4:
			return b2;
		case 5:
			return CementaMasina;
		case 6:
			return e46;
		case 7:
			return e61;
		case 8:
			return Eskavators;
		case 9:
			return policija;
		case 10:
			return Traktors1;
		case 11:
			return Traktors5;
		case 12:
			return Ugunsdzeseji;
		default:
			return null;
		}
	}
}
