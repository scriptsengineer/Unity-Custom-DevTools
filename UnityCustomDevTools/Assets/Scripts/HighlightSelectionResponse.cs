using UnityEngine;

public class HighlightSelectionResponse : MonoBehaviour,ISelectionResponse
{
    [SerializeField]
    public Material highLightMaterial;

    [SerializeField]
    public Material defaultMaterial;

    public void OnDeselect(Transform selection)
    {
        var selectionRenderer = selection.GetComponent<Renderer>();
        if (selectionRenderer != null)
        {
            selectionRenderer.material = defaultMaterial;
        }
    }

    public void OnSelect(Transform selection)
    {
        var selectionRenderer = selection.GetComponent<Renderer>();
        if (selection != null)
        {
            selectionRenderer.material = highLightMaterial;
        }
    }

}