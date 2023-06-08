using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheat : MonoBehaviour
{
	public Objekti objektuSkripts;

	private Vector2[] initialPositions; // Изначальные позиции машинок

	private void Start()
	{
		// Сохраняем изначальные позиции машинок
		initialPositions = new Vector2[]
		{
			objektuSkripts.atkrMKoord,
			objektuSkripts.atrPKoord,
			objektuSkripts.bussKoord,
			objektuSkripts.b2Koord,
			objektuSkripts.CemKoord,
			objektuSkripts.e46Koord,
			objektuSkripts.e61Koord,
			objektuSkripts.EskKoord,
			objektuSkripts.polKoord,
			objektuSkripts.Trak1Koord,
			objektuSkripts.Trak5Koord,
			objektuSkripts.UgunsKoord
		};
	}

	private void Update()
	{
		// Проверяем, нажата ли кнопка Q
		if (Input.GetKeyDown(KeyCode.Q))
		{
			ResetCarsPositions();
			Debug.Log("aahhahahahaha");
		}
	}

	private void ResetCarsPositions()
	{
		// Перемещаем все машинки на их изначальные позиции
		objektuSkripts.atkritumuMasina.GetComponent<RectTransform>().localPosition = initialPositions[0];
		objektuSkripts.atraPalidziba.GetComponent<RectTransform>().localPosition = initialPositions[1];
		objektuSkripts.autobuss.GetComponent<RectTransform>().localPosition = initialPositions[2];
		objektuSkripts.b2.GetComponent<RectTransform>().localPosition = initialPositions[3];
		objektuSkripts.CementaMasina.GetComponent<RectTransform>().localPosition = initialPositions[4];
		objektuSkripts.e46.GetComponent<RectTransform>().localPosition = initialPositions[5];
		objektuSkripts.e61.GetComponent<RectTransform>().localPosition = initialPositions[6];
		objektuSkripts.Eskavators.GetComponent<RectTransform>().localPosition = initialPositions[7];
		objektuSkripts.policija.GetComponent<RectTransform>().localPosition = initialPositions[8];
		objektuSkripts.Traktors1.GetComponent<RectTransform>().localPosition = initialPositions[9];
		objektuSkripts.Traktors5.GetComponent<RectTransform>().localPosition = initialPositions[10];
		objektuSkripts.Ugunsdzeseji.GetComponent<RectTransform>().localPosition = initialPositions[11];
	}
}
