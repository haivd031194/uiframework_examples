using System;
using System.Collections.Generic;
using deVoid.UIFramework;
using deVoid.Utils;
using UnityEngine;

namespace SE.UIFramework.Examples
{
    public class UIDemoController : MonoBehaviour
    {
        private UIFrame uiFrame;

        private void Awake() {
            LoadUIFrame();
            //Signals.Get<StartDemoSignal>().AddListener(OnStartDemo);
        }

        private void LoadUIFrame()
        {
            var uiFrameName = Screen.orientation == ScreenOrientation.Landscape ? "DemoPrefabs/H_UIFrame" : "DemoPrefabs/V_UIFrame";
            var uiFramePrefab = Resources.Load<GameObject>(uiFrameName);
            if (uiFramePrefab)
            {
                Instantiate<GameObject>(uiFramePrefab);
                uiFrame = UIFrame.Instance;
            }
            else
            {
                throw new Exception("DemoPrefabs/UIFrame is not exist");
            }
                
        }

        private void OnDestroy() {
            //Signals.Get<StartDemoSignal>().RemoveListener(OnStartDemo);
        }

        private void Start() {
            uiFrame.OpenWindow(ScreenIds.TapToPlayWindowV);
        }

        private void OnStartDemo() {
            // The navigation panel will automatically navigate
            // to the first screen upon opening
            //uiFrame.ShowPanel(ScreenIds.NavigationPanel);
            //uiFrame.ShowPanel(ScreenIds.ToastPanel);
        }

        private void OnNavigateToWindow(string windowId) {
            // You usually don't have to do this as the system takes care of everything
            // automatically, but since we're dealing with navigation and the Window layer
            // has a history stack, this way we can make sure we're not just adding
            // entries to the stack indefinitely
            uiFrame.CloseCurrentWindow();

            //switch (windowId) {
            //    case ScreenIds.PlayerWindow:
            //        uiFrame.OpenWindow(windowId, new PlayerWindowProperties(fakePlayerData.LevelProgress));
            //        break;
            //    case ScreenIds.CameraProjectionWindow:
            //        transformToFollow.parent.gameObject.SetActive(true);
            //        uiFrame.OpenWindow(windowId, new CameraProjectionWindowProperties(cam, transformToFollow));
            //        break;
            //    default:
            //        uiFrame.OpenWindow(windowId);
            //        break;
            //}
        }

        //private void OnShowConfirmationPopup(ConfirmationPopupProperties popupPayload) {
        //    uiFrame.OpenWindow(ScreenIds.ConfirmationPopup, popupPayload);
        //}
    }
}