using UnityEngine;

public class InputReader : MonoBehaviour
{
    private KitchenInputActions kitchenInputActions;

    private void Awake()
    {
        kitchenInputActions = new KitchenInputActions();
        kitchenInputActions.Camera.Enable();
    }

    public float GetZInput()
    {
        return kitchenInputActions.Camera.Move.ReadValue<float>();
    }
}
