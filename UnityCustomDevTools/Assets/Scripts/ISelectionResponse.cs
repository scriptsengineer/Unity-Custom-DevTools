using UnityEngine;

public interface ISelectionResponse
{
    void OnSelect(Transform selection);

    void OnDeselect(Transform selection);
}