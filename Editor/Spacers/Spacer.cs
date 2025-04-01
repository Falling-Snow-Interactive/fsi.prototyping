using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace fsi.prototyping.Spacers
{
    [UxmlElement]
    public partial class Spacer : VisualElement
    {
        private static Color DefaultColor => new(42f/255f, 42f/255f, 42f/255f, 1f);
        private static Color LightColor => new(72f/255f, 72f/255f, 72f/255f, 1f);
        
        private const string DocumentPath = "Packages/com.fallingsnowinteractive.prototyping/Editor/Spacers/Spacer_UI.uxml";
        
        public Spacer()
        {
            #if UNITY_EDITOR
            // VisualTreeAsset asset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(DocumentPath);
            // asset.CloneTree(this);

            VisualElement root = new()
                                 {
                                     style =
                                     {
                                         backgroundColor = DefaultColor,
                                         
                                         height = 3f,
                                         
                                         marginTop = 5,
                                         marginBottom = 5,
                                         marginLeft = 5,
                                         marginRight = 5,
                                         
                                         borderBottomLeftRadius = 3,
                                         borderBottomRightRadius = 3,
                                         borderTopLeftRadius = 3,
                                         borderTopRightRadius = 3,
                                     }
                                 };
            
            Add(root);
            #endif
        }
        
        public Spacer(float size, bool wide = true, bool light = false)
        {
            #if UNITY_EDITOR
            // VisualTreeAsset asset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(DocumentPath);
            // asset.CloneTree(this);

            VisualElement root = new()
                                 {
                                     style =
                                     {
                                         backgroundColor = light ? LightColor : DefaultColor,
                                         
                                         marginTop = 5,
                                         marginBottom = 5,
                                         marginLeft = 5,
                                         marginRight = 5,
                                         
                                         borderBottomLeftRadius = 3,
                                         borderBottomRightRadius = 3,
                                         borderTopLeftRadius = 3,
                                         borderTopRightRadius = 3,
                                     }
                                 };

            if (wide)
            {
                root.style.height = size;
            }
            else
            {
                root.style.width = size;
            }
            
            Add(root);
            #endif
        }

        public static Spacer Wide(float height = 3)
        {
            return new Spacer(height);
        }
        
        public static VisualElement Tall(float width = 3)
        {
            return new Spacer(width, false);
        }

        public static Spacer LightWide(float width = 3)
        {
            return new Spacer(width, true, true);
        }
    }
}
