using UnityEngine;

public class MouseScreenRayProvider : MonoBehaviour, IRayProvider
{
    public Ray CreateRay(){
        return Camera.main.ScreenPointToRay(Input.mousePosition);
    }
}