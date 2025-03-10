using UnityEditor;
using UnityEngine.UIElements;

namespace fsi.prototyping.Spacers
{
    [UxmlElement]
    public partial class Spacer : VisualElement
    {
        private const string DocumentPath = "Packages/com.fallingsnowinteractive.prototyping/Editor/Spacers/Spacer_UI.uxml";
        
        public Spacer()
        {
            #if UNITY_EDITOR
            VisualTreeAsset asset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(DocumentPath);
            asset.CloneTree(this);
            #endif
        }
    }
}
