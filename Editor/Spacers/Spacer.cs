using UnityEditor;
using UnityEngine.UIElements;

namespace Fsi.Prototyping.Editor.Spacers
{
    [UxmlElement]
    public partial class Spacer : VisualElement
    {
        private const string DOCUMENT_PATH = "Packages/com.fallingsnowinteractive.prototyping/Editor/Spacers/Spacer_UI.uxml";
        
        public Spacer()
        {
            #if UNITY_EDITOR
            var asset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(DOCUMENT_PATH);
            asset.CloneTree(this);
            #endif
        }
    }
}
