using UnityEngine;

public class Hole : MonoBehaviour
{
    [SerializeField]
    public int holeNumber;

    [SerializeField]
    public Score scoreManager;

    private void OnTriggerEnter(Collider other)
    {
        scoreManager.UpdateScore(holeNumber);
    }
}
