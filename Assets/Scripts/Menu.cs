using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void BackToMenu() => SceneManager.LoadScene(0);
}