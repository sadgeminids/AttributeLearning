using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeLearning
{


    public class Effect
    {

    }
    public class Animation
    {

    }

    public class EditorBase
    {
        public virtual void OnGUI()
        {
            Console.WriteLine("EditorBase OnGUI");
        }
    }

    [EditorAttribute(typeof(Effect))]

    public class EffectEditor : EditorBase
    {
        public override void OnGUI()
        {
            Console.WriteLine("EffectEditor OnGUI");
        }
    }

    [EditorAttribute(typeof(Animation))]

    public class AnimationEditor : EditorBase
    {
        public override void OnGUI()
        {
            Console.WriteLine("AnimationEditor OnGUI");
        }
    }




    public class Sound
    {

    }

    [EditorAttribute(typeof(Sound))]

    public class SoundEditor : EditorBase
    {
        public override void OnGUI()
        {
            Console.WriteLine("SoundEditor OnGUI");
        }
    }
}
