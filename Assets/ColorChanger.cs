using VRTK;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public VRTK_DestinationMarker rightController;
   
   

    public void OnEnable()
    {
        rightController.DestinationMarkerSet += RightController_DestinationMartkerSet; 
    }

    private void OnDisable()
    {
        rightController.DestinationMarkerSet -= RightController_DestinationMartkerSet;
    }

    public void RightController_DestinationMartkerSet(object sender, DestinationMarkerEventArgs e)
    {

        Renderer fr = e.target.GetComponent<Renderer>();
        if (fr != null)
        {
            fr.material.color = Color.cyan;
        }
    }
}
