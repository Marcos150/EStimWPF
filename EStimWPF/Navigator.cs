using Microsoft.Xaml.Behaviors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace EStimWPF
{
    internal class Navigator
    {
        public static void Navigate(List<Frame> frames, string search)
        {
            foreach(Frame frame in frames)
            {
                if (frame.Name.Contains(search))
                {
                    frame.Visibility = Visibility.Visible;
                }
                else if (frame.Name != "menu" && frame.Name != "nav")
                {
                    frame.Visibility = Visibility.Collapsed;
                }
            }
        }

        public static void Login(List<Frame> frames, string search)
        {
            foreach (Frame frame in frames)
            {
                if(search.Contains(frame.Name))
                {
                    frame.Visibility = Visibility.Visible;
                }
                else
                {
                    frame.Visibility = Visibility.Collapsed;
                }
            }
        }
    }
}
