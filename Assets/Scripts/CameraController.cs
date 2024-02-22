using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private float maxXPosition = 4.1f;
    private float minXPosition = -5.25f;
    private float maxYPosition = 3f;
    private float minYPosition = -3f;
    private void Update() 
    {
        transform.position = new Vector3(Mathf.Clamp(player.transform.position.x, minXPosition, maxXPosition), Mathf.Clamp(player.transform.position.y, minYPosition, maxYPosition), -10f);
    }
}