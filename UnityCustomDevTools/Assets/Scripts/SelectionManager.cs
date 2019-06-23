using UnityEngine;

public class SelectionManager : MonoBehaviour
{

    [SerializeField]
    private string selectionTag = "Selectable";


    private Transform selection;

    private ISelectionResponse selectionResponse;


    private void Awake() {
        selectionResponse = GetComponent<ISelectionResponse>();
    }

    private void Update()
    {

        // Deselection/Selection Response
        if (selection != null)
        {
            selectionResponse.OnDeselect(selection);
        }

        #region Selection Determination
        // Creating a Ray
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        selection = null;

        // Selection Determination
        if (Physics.Raycast(ray, out var hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag(selectionTag))
            {
                this.selection = selection;
            }

        }
        #endregion

        // Deselection/Selection Response
        if (selection != null)
        {
            selectionResponse.OnSelect(selection);
        }

    }

}
