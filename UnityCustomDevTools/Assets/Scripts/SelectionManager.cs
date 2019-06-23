using UnityEngine;

public class SelectionManager : MonoBehaviour
{

    [SerializeField]
    private string selectionTag = "Selectable";

    [SerializeField]
    private Material highLightMaterial;

    [SerializeField]
    private Material defaultMaterial;


    private Transform selection;


    private void Update()
    {

        if(selection != null){
            var selectionRenderer = selection.GetComponent<Renderer>(); 
            selectionRenderer.material = defaultMaterial;
            selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);


        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            if(selection.tag == selectionTag){
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    selectionRenderer.material = highLightMaterial;
                }
                this.selection = selection;
            }
            
        }

    }

}