using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    private bool isPaused = false;
   

   

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }

        if (isPaused)
        {
            Time.timeScale = 0f; // Устанавливаем коэффициент времени в 0, чтобы остановить игровое время
            Cursor.lockState = CursorLockMode.Locked; // Блокируем указатель мыши
            Cursor.visible = false; // Скрываем указатель мыши
        }
        else
        {
            Time.timeScale = 1f; // Возобновляем нормальный коэффициент времени для продолжения игры
            Cursor.lockState = CursorLockMode.None; // Разблокируем указатель мыши
            Cursor.visible = true; // Показываем указатель мыши
        }
    }

    private void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            // Дополнительные действия при паузе, если нужно
        }
        else
        {
            // Дополнительные действия при снятии паузы, если нужно
        }
    }
}
