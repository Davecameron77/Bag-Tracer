using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Bag_Tracer.View.Fragments
{
    class CloseableTab : TabItem
    {
        public CloseableTab()
        {
            TabHeader = new CloseableTabHeader();
            this.Header = TabHeader;

            TabHeader.button_close.MouseEnter += new MouseEventHandler(button_close_MouseEnter);
            TabHeader.button_close.MouseLeave += new MouseEventHandler(button_close_MouseLeave);
            TabHeader.button_close.Click += new RoutedEventHandler(button_close_Click);
            TabHeader.label_TabTitle.SizeChanged += new SizeChangedEventHandler(label_TabTitle_SizeChanged);
        }

        public CloseableTabHeader TabHeader { get; set; }

        public string Title
        {
            set
            {
                ((CloseableTabHeader)this.Header).label_TabTitle.Content = value;
            }
        }

        protected override void OnSelected(RoutedEventArgs e)
        {
            base.OnSelected(e);
            ((CloseableTabHeader)this.Header).button_close.Visibility = Visibility.Visible;
        }

        protected override void OnUnselected(RoutedEventArgs e)
        {
            base.OnUnselected(e);
            ((CloseableTabHeader)this.Header).button_close.Visibility = Visibility.Hidden;
        }

        protected override void OnMouseEnter(MouseEventArgs e)
        {
            base.OnMouseEnter(e);
            ((CloseableTabHeader)this.Header).button_close.Visibility = Visibility.Visible;
        }
        
        protected override void OnMouseLeave(MouseEventArgs e)
        {
            base.OnMouseLeave(e);
            if (!this.IsSelected)
            {
                ((CloseableTabHeader)this.Header).button_close.Visibility = Visibility.Hidden;
            }
        }
        void button_close_MouseEnter(object sender, MouseEventArgs e)
        {
            ((CloseableTabHeader)this.Header).button_close.Foreground = Brushes.Red;
        }

        // Button MouseLeave - When mouse is no longer over button - change color back to black
        void button_close_MouseLeave(object sender, MouseEventArgs e)
        {
            ((CloseableTabHeader)this.Header).button_close.Foreground = Brushes.Black;
        }

        // Button Close Click - Remove the Tab - (or raise
        // an event indicating a "CloseTab" event has occurred)
        void button_close_Click(object sender, RoutedEventArgs e)
        {
            ((TabControl)this.Parent).Items.Remove(this);
        }
        // Label SizeChanged - When the Size of the Label changes
        // (due to setting the Title) set position of button properly

        void label_TabTitle_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ((CloseableTabHeader)this.Header).button_close.Margin = new Thickness(
               ((CloseableTabHeader)this.Header).label_TabTitle.ActualWidth + 5, 3, 4, 0);
        }
    }
}
