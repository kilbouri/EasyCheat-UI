using UnityEngine;

namespace Cheats {
    public class CheatsUIManager : MonoBehaviour {

        [Header("Folding Customization")]
        [SerializeField] private float foldSpeed = 1f;
        [SerializeField] private float edgePadding = 10f;
        [SerializeField] private bool lockViewOnOpen = false;

        [SerializeField] private RectTransform cheatUI;
        public KeyCode toggleKey = KeyCode.F10;

        [HideInInspector] public bool showCheatsUI;

        void Update() {
            // handles state toggle
            showCheatsUI = Input.GetKeyUp(toggleKey) ? !showCheatsUI : showCheatsUI;
            if (lockViewOnOpen) SetViewLock(showCheatsUI);

            // lerp towards appropriate position based on the new state of showCheatsUI
            float halfWidth = cheatUI.rect.width / 2f;
            float targetPos = showCheatsUI ? halfWidth + edgePadding : -halfWidth - edgePadding;
            float lerpDelta = Time.deltaTime * foldSpeed * 5f;
            
            cheatUI.anchoredPosition = new Vector2(Mathf.Lerp(cheatUI.anchoredPosition.x, targetPos, lerpDelta), cheatUI.localPosition.y);
        }

        // Called by the close button
        public void close() {
            showCheatsUI = false;
        }

        // Called to inform the game of whether or not to lock the camera and free the mouse.
        private void SetViewLock(bool b) {
            throw new System.NotImplementedException("You still need to implement view locking!");
        }

        // Called by cheats that should invalidate the player's score.
        public void InvalidateScore() {
            throw new System.NotImplementedException("You still need to implement the invalidation of score!");
        }
    }
}