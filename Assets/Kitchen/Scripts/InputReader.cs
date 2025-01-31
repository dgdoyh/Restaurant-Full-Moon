using UnityEngine;

public class InputReader : MonoBehaviour
{
    public float GetZInput()
    {
        if (Input.GetKey(KeyCode.A)) { return -1f; }
        if (Input.GetKey(KeyCode.D)) { return 1f; }

        return 0f;
    }
}
