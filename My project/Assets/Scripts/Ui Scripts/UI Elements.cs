using UnityEngine;
using UnityEngine.SceneManagement;

public class UIElements : MonoBehaviour
{
    public void Openlevel(int levelToLoad)
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
