using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace NisTest
{
    [Serializable]
    public sealed class Vector2Event : UnityEvent<Vector2> {}

    public class Composite2DAxisActionConverter : MonoBehaviour
    {
        public Vector2Event eventToFire;

        public void OnAction(InputAction.CallbackContext context)
        {
            var value = context.ReadValue<Vector2>();
            //Debug.Log(value);

            eventToFire?.Invoke(value);
        }
    }
}