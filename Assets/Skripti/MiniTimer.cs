using UnityEngine;
using UnityEngine.UI;

public class MiniTimer : MonoBehaviour
{
	private float currentTime;    // Текущее время секундомера
	private bool isRunning;       // Флаг, указывающий, запущен ли секундомер

	public Text timerText;        // Ссылка на компонент текста, отображающего время секундомера

	private void Start()
	{
		StartTimer();  // Запустить секундомер при старте программы
	}

	private void Update()
	{
		if (isRunning)
		{
			currentTime += Time.deltaTime;
			UpdateTimerText();
		}
	}

	public void StartTimer()
	{
		isRunning = true;
		currentTime = 0f;
	}

	public void StopTimer()
	{
		isRunning = false;
		UpdateTimerText();
	}

	private void UpdateTimerText()
	{
		int minutes = Mathf.FloorToInt(currentTime / 60f);
		int seconds = Mathf.FloorToInt(currentTime % 60f);
		timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
	}
}
