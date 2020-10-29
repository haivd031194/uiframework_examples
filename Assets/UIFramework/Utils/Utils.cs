namespace UnityEngine
{
    public static class ScreenUtils
    {
        /// <summary>
        /// you need to custom for your application to test on editor
        /// Currently screen orientation is only relevant on mobile platforms: https://docs.unity3d.com/ScriptReference/Screen-orientation.html
        /// </summary>
        public static bool IsLandscape
        {
            get {
                if (Application.isMobilePlatform)
                {
                    return Screen.orientation == ScreenOrientation.LandscapeLeft || Screen.orientation == ScreenOrientation.LandscapeRight;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}