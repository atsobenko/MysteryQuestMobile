using UnityEngine;

public class HighlightItem : MonoBehaviour
{
    public Material standartMaterial;
    public Material highlightMaterial;
    public Renderer componentRenderer;

    private void OnTriggerEnter2D(Collider2D inputCollider)
    {
        SetMaterial(highlightMaterial, inputCollider);
    }

    private void OnTriggerExit2D(Collider2D inputCollider)
    {
        SetMaterial(standartMaterial, inputCollider);
    }

    private void SetMaterial(Material material, Collider2D inputCollider)
    {

        if (!inputCollider.CompareTag("Player") || !componentRenderer)
        {
            return;
        }

        componentRenderer.material = material;
    }
}
