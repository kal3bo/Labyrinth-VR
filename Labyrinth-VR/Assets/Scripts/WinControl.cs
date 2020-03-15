using UnityEngine;

public class WinControl : MonoBehaviour
{
    public GameObject _WinCanvas;
    public GameObject _Score;
    
    private void OnTriggerEnter(Collider other)
    {
        _WinCanvas.SetActive(true);
        _Score.SetActive(false);
    }
}
