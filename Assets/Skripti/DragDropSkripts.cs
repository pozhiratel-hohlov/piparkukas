using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDropSkripts : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	public Objekti objektuSkripts;
	private CanvasGroup kanvasGrupa;
	private RectTransform velkObjRectTransf;
	private int carsInPlace = 0;

	public GameObject timePanel;
	public Text timeText;

	private bool isGameFinished = false;
	private float startTime;

	void Start()
	{
		kanvasGrupa = GetComponent<CanvasGroup>();
		velkObjRectTransf = GetComponent<RectTransform>();
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		Debug.Log("Uzklikšķināts uz velkama objekta!");
		objektuSkripts.pedejaisVilktais = null;
		kanvasGrupa.alpha = 0.6f;
		kanvasGrupa.blocksRaycasts = false;
	}

	public void OnDrag(PointerEventData eventData)
	{
		velkObjRectTransf.anchoredPosition += eventData.delta / objektuSkripts.kanva.scaleFactor;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		objektuSkripts.pedejaisVilktais = eventData.pointerDrag;
		kanvasGrupa.alpha = 1f;

		if (objektuSkripts.vaiIstajaVieta == false)
		{
			kanvasGrupa.blocksRaycasts = true;
		}
		else
		{
			objektuSkripts.pedejaisVilktais = null;
			carsInPlace++;
		}

		objektuSkripts.vaiIstajaVieta = false;

		CheckAllCarsPlaced();
	}

	public void OnPointerDown(PointerEventData eventData)
	{

	}

	private void CheckAllCarsPlaced()
	{
		if (carsInPlace == objektuSkripts.totalcars && !isGameFinished)
		{
			isGameFinished = true;
			Time.timeScale = 0;
			timePanel.SetActive(true);

			float elapsedTime = Time.time - startTime;
			string formattedTime = FormatTime(elapsedTime);
			timeText.text = "Aizņemtais laiks: " + formattedTime;
		}
	}

	public void RestartGame()
	{
		Time.timeScale = 1;
		carsInPlace = 0;
		isGameFinished = false;
		timePanel.SetActive(false);
		startTime = Time.time;
		// Дополнительный код для сброса значений и состояния игры
	}

	private string FormatTime(float time)
	{
		int minutes = (int)(time / 60);
		int seconds = (int)(time % 60);
		return string.Format("{0:00}:{1:00}", minutes, seconds);
	}
}
