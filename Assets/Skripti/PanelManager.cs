using UnityEngine;

public class PanelManager : MonoBehaviour
{
	public Objekti objektuSkripts;
	private CanvasGroup panelCanvasGroup;

	private void Awake()
	{
		panelCanvasGroup = GetComponent<CanvasGroup>();
		HidePanel();
	}

	private void Update()
	{
		if (objektuSkripts != null && objektuSkripts.carsInPlace == objektuSkripts.totalcars)
		{
			ShowPanel();
		}
		else
		{
			HidePanel();
		}
	}

	public void ShowPanel()
	{
		panelCanvasGroup.alpha = 1f;
		panelCanvasGroup.interactable = true;
		panelCanvasGroup.blocksRaycasts = true;
	}

	public void HidePanel()
	{
		panelCanvasGroup.alpha = 0f;
		panelCanvasGroup.interactable = false;
		panelCanvasGroup.blocksRaycasts = false;
	}
}
