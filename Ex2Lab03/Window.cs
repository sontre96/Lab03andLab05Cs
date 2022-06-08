using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Lab03
{
    class Window
    {
        protected int top;
        protected int left;

        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        // simulates drawing the window
        public virtual void DrawWindow()
        {
            Console.WriteLine("Window: drawing Window at {0}, {1}", top, left);
        }
    }

    // Create class ListBox
    class ListBox : Window
    {
        private string listBoxContents { get; set; }

        public ListBox(int top, int left, string contents) : base(top, left) // call base constructor
        {
            listBoxContents = contents;
        }

        public override void DrawWindow()
        {
            base.DrawWindow();//invoke the base method
            Console.WriteLine("Writing string to the listBox: {0}", listBoxContents);

        }
    }

    class Button : Window
    {
        public Button(int top, int left) : base(top, left)
        {
        }

        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a button at {0} {1}\n", top, left);
        }
    }
}
