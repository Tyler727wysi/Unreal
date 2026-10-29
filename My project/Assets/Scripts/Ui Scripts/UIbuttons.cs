using UnityEngine;
using UnityEngine.SceneManagement;

public class UIbuttons : MonoBehaviour
{
    [SerializeField] private GameObject[] uiElements;

    public void OpenLevel(int levelToLoad)
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void ShowElement(GameObject elementToShow)
    {
        ToggleInactive();
        elementToShow.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
    private void ToggleInactive()
    {
        for (int i = 0; i < uiElements.Length; i++)
        {
            uiElements[i].SetActive(false);
        }
    }
}
