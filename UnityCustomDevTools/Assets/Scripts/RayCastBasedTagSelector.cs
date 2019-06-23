using UnityEngine;

public class RayCastBasedTagSelector : MonoBehaviour,ISelector
{

    [SerializeField]
    private string selectionTag = "Selectable";

    
    private Transform selection;

    public void Check(Ray ray){
        selection = null;
        if (Physics.Raycast(ray, out var hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag(selectionTag))
            {
                this.selection = selection;
            }

        }
    }

    
    public Transform GetSelection(){
        return selection;
    }

}