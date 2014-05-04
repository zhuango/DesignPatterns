using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class Adapter, Only for TextView, not Child of TextView.
            TextShapeClassInheritAdapter textViewAdapter = new TextShapeClassInheritAdapter();
            Manipulator manipulator = textViewAdapter.CreateManipulator();

            //Object Adapter is more agile
            TextView textView2 = new TextView();
            TextShapeObjectComAdapter textViewObjAdapter = new TextShapeObjectComAdapter(textView2);
            Manipulator manipulatorObj = textViewObjAdapter.CreateManipulator();

            SupperTextView supperTextView = new SupperTextView();
            TextShapeObjectComAdapter supperTextViewObjAdapter = new TextShapeObjectComAdapter(supperTextView);
            Manipulator supperTextManipulator = supperTextViewObjAdapter.CreateManipulator();
        }
    }
}
