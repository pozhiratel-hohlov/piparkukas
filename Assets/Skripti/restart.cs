using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
	public void RestartGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
