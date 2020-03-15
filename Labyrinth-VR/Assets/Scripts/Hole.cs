using UnityEngine;

public class Hole : MonoBehaviour
{
    public int holeNumber;
    public Score scoreManager;

    private void OnTriggerEnter(Collider other)
    {
        scoreManager.UpdateScore(holeNumber);
    }
}
