using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    private IRayProvider rayProvider;
    private ISelector selector;
    private ISelectionResponse selectionResponse;

    private Transform currentSelection;

    private void Awake() {
        rayProvider = GetComponent<IRayProvider>();
        selector = GetComponent<ISelector>();
        selectionResponse = GetComponent<ISelectionResponse>();
    }

    private void Update()
    {
        // Deselection/Selection Response
        if (currentSelection != null)
            selectionResponse.OnDeselect(currentSelection);
        
        selector.Check(rayProvider.CreateRay());
        currentSelection = selector.GetSelection();

        // Deselection/Selection Response
        if (currentSelection != null)
            selectionResponse.OnSelect(currentSelection);

    }



    
    

}
