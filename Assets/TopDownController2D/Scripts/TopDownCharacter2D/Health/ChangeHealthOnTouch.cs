using UnityEngine;

namespace TopDownCharacter2D.Health
{
    /// <summary>
    ///     This script allows an entity to deal contact damage to other entities with a given tag
    /// </summary>
    public class ChangeHealthOnTouch : MonoBehaviour
    {
        [Tooltip("The health change on contact (must be negative for damages)")] [SerializeField]
        private float value;

        [Tooltip("The tag of the target of the health change")] [SerializeField]
        private string targetTag;
        private TopDownKnockBack _collidingTargetKnockBackSystem;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            GameObject receiver = collision.gameObject;

            if (!receiver.CompareTag(targetTag))
            {
                return;
            }

            _collidingTargetKnockBackSystem = receiver.GetComponent<TopDownKnockBack>();
        }
    }
}