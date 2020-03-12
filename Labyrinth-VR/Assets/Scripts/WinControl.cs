using UnityEngine;

public class WinControl : MonoBehaviour
{
    [SerializeField]
    public GameObject _WinCanvas;
    [SerializeField]
    public GameObject _Score;
    
    private void OnTriggerEnter(Collider other)
    {
        _WinCanvas.SetActive(true);
        _Score.SetActive(false);
    }
}
