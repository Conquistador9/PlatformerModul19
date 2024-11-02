using UnityEngine;

public class End : MonoBehaviour
{
    [SerializeField] private GameObject _endPanel;

    public void EndPanelActive()
    {
        _endPanel.SetActive(true);
    }
}