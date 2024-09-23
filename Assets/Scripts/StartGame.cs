using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StartLevelOne() => SceneManager.LoadScene(1);
}