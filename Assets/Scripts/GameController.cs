using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private GameObject crossPrefab;

    [SerializeField]
    private GameObject circlePrefab;

    public static GameController Instance;

    private bool crossTurn = true;

    private void Awake()
    {
        Instance = this;
    }

    public void PlayTurn(Target target)
    {
        Instantiate(crossTurn ? crossPrefab : circlePrefab, target.transform, false);
        target.enabled = false;
        EndTurn();
    }

    public void EndTurn()
    {
        crossTurn = !crossTurn;
    }
}
