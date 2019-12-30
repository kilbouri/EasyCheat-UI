using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cheats {
    public class CheatsUIManager : MonoBehaviour {

        public bool showCheatsUI = false;
        public GameObject parent;
        public KeyCode toggleKey = KeyCode.F10;
        public Animator animator;

        private bool firstRun = true;

        void Update () {
            if (Input.GetKeyDown(toggleKey)) {
                if (firstRun) {
                    animator.SetFloat("initial", 1);
                    firstRun = false;
                }
                showCheatsUI = !showCheatsUI;
                VerifyCheatsUI();
            }
        }
        public void CloseButton () {
            showCheatsUI = false;
            VerifyCheatsUI();
        }
        public void VerifyCheatsUI () {

            SetViewLock(showCheatsUI);
            if (showCheatsUI) {
                StartAnimationReverse();
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            } else if (!showCheatsUI) {
                StartAnimationForward();
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        public void StartAnimationForward () {
            animator.SetBool("forRev", true);
        }
        public void StartAnimationReverse () {
            animator.SetBool("forRev", false);
        }
        private void SetViewLock (bool b) {
            throw new System.NotImplementedException("You still need to implement view locking!");
        }
    }
}