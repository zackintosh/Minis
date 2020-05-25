using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Zack
{
    [System.Serializable] public sealed class Vector2Event : UnityEvent<Vector2> { };

    public class Composite2DAxisActionConverter : MonoBehaviour
    {
        public Vector2Event eventToFire = null;

        public void OnAction(InputAction.CallbackContext context)
        {
            var value = context.ReadValue<Vector2>();
            //Debug.Log(value);

            eventToFire?.Invoke(value);
        }
    }
}
