using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using BasicLinkedList.Stack;
using BasicLinkedList.Queue;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BasicLinkedList
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GameEntryUI : Window
    {
        public GameEntryUI()
        {
            this.InitializeComponent();

            CStack lifeStack = new CStack();
            lifeStack.Push(3);
            lifeStack.Push(2);
            lifeStack.Push(1);
          int popped =  lifeStack.Pop();
            int check = lifeStack.Peek();

            CQueue queue = new CQueue();
            queue.Add("Player1");
            queue.Add("Player2");
            queue.Add("Player 3");
            queue.Pop();
            queue.Peek();
            
        }
    }
}
