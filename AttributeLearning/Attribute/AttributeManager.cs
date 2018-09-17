using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AttributeLearning
{
    public class AttributeManager
    {
        // Key       param of EditorAttribute() which mast be class
        // Value     classes that are marked by EditorAttribut
        static Dictionary<Type, Type> m_typeMap = new Dictionary<Type, Type>();

        // find all classes marked by EditorAttribut
        public static void Init()
        {
            var assembiles = System.AppDomain.CurrentDomain.GetAssemblies();
            foreach (Assembly assemb in assembiles)
            {
                var types = assemb.GetTypes();
                foreach (Type type in types)
                {
                    var attributes = type.GetCustomAttributes();
                    foreach (Attribute attr in attributes)
                    {
                        EditorAttribute editorAttribute = attr as EditorAttribute;
                        if (editorAttribute != null)
                            m_typeMap[editorAttribute.type] = type;
                    }
                }
            }
        }

        public static EditorBase CreateEditor(Type t)
        {
            EditorBase editor = null;
            if (m_typeMap[t] != null)
            {
                Type EditorType = m_typeMap[t];
                editor = System.Activator.CreateInstance(EditorType) as EditorBase;
                Console.WriteLine("Editor type " + EditorType.Name);
            }
            return editor;
        }
    }
}
