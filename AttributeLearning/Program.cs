using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeLearning
{
    public class Program
    {
        static void Main(string[] args)
        {
            AttributeManager.Init();

            Effect effect = new Effect();
            Animation animation = new Animation();

            EditorBase effectEditor = AttributeManager.CreateEditor(effect.GetType());
            EditorBase animationEditor = AttributeManager.CreateEditor(animation.GetType());

            effectEditor.OnGUI();
            animationEditor.OnGUI();

            Console.ReadKey();
        }
    }
}
