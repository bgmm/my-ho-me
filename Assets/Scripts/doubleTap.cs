using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.EventSystems
{

    public class doubleTap : MonoBehaviour, IPointerClickHandler
    {
        int tap;
        public void OnPointerClick(PointerEventData eventData)
        {
            tap = eventData.clickCount;

            if (tap == 2)
            {
                // do something
                Debug.Log("doubleTap");
            }

            if (tap == 1)
            {
                Debug.Log("Sorry");
            }
            else
                    {

                Debug.Log("Why");
            }
        }
    }
}
