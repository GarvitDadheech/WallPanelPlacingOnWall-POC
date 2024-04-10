using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using TMPro;

public class WallPanelScript : MonoBehaviour
{
    public XRRayInteractor rayInteractorLeft;
    public XRRayInteractor rayInteractorRight;

    public InputActionReference leftPointAction;
    public InputActionReference rightPointAction;

    public GameObject wallPanel;
    private Renderer wallRenderer;
    public TextMeshPro costText;



    void Start()
    {
        leftPointAction.action.performed += SetMaterialToWall;
        rightPointAction.action.performed += SetMaterialToWall;
        wallRenderer = wallPanel.GetComponent<Renderer>();
    }

    private void SetMaterialToWall(InputAction.CallbackContext context)
    {
        XRRayInteractor rayInteractor;
        if (context.action == leftPointAction.action)
            rayInteractor = rayInteractorLeft;
        else if (context.action == rightPointAction.action)
            rayInteractor = rayInteractorRight;
        else
            return;

        RaycastHit hit;
        if (rayInteractor.TryGetCurrent3DRaycastHit(out hit))
        {
            Renderer planeRenderer = hit.collider.GetComponent<Renderer>();
            if (planeRenderer != null)
            {
                // Set the material
                wallRenderer.material = planeRenderer.material;

                // Set the tiling property for vertical tiling
                Vector2 tiling = new Vector2(10f, 1f); 
                wallRenderer.material.mainTextureScale = tiling;
                int totalCost = 10 * 50;
                costText.text = "Total Cost:Rs." + totalCost.ToString("0.00");
                costText.fontSize = 20;
            }
        }
    }
}
