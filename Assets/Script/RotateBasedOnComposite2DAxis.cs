using UnityEngine;

namespace NisTest
{
    public class RotateBasedOnComposite2DAxis : MonoBehaviour
    {
        public float angleScale = 90.0f;
        public Vector3 xMap = new Vector3(0.0f, -1.0f, 0.0f);
        public Vector3 yMap = new Vector3(1.0f, 0.0f, 0.0f);

        public void RotateVector2(Vector2 vector)
        {
            var angle = (xMap * vector.x + yMap * vector.y) * angleScale;
            transform.localRotation = Quaternion.Euler(angle);
        }
    }
}