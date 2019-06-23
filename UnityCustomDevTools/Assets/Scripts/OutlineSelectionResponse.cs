using UnityEngine;

public class OutlineSelectionResponse : MonoBehaviour, ISelectionResponse
{
    public void OnDeselect(Transform selection)
    {
        var outline = selection.GetComponent<Outline>();
        if(outline != null)
            outline.OutlineWidth = 0;
    }

    public void OnSelect(Transform selection)
    {
        var outline = selection.GetComponent<Outline>();
        if(outline != null)
            outline.OutlineWidth = 10;
    }

}