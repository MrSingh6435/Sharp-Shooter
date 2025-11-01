using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text enemiesLeftText;
    [SerializeField] GameObject youWinText;
    int enemiesLeft = 0;
    const string ENEMIES_LEFT_STRING = "Enemies Left: ";
    public void AdjustEnemiesLeft(int amount)
    {
        enemiesLeft += amount;
        enemiesLeftText.text = ENEMIES_LEFT_STRING + enemiesLeft.ToString();
        if (enemiesLeft <= 0)
        {
            youWinText.SetActive(true);
        }
    }
    public void RestartButton()
    {
        int currntScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currntScene);
    }
    public void QuitButton()
    {
        Debug.LogWarning("Trying to Quiting game! Not working in editor! You Silly goose!");
        Application.Quit();
    }
}
