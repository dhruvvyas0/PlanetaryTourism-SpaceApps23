using UnityEngine;

public class ShowInfo : MonoBehaviour
{
     public GameObject toTurnOff;

    public void TurnOff()
    {
        if(toTurnOff.activeInHierarchy == true)
        {
            toTurnOff.SetActive(false);
        }
        else
        {
            toTurnOff.SetActive(true);
        }
    }
}