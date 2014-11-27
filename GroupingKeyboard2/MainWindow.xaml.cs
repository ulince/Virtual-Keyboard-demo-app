using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GroupingKeyboard2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Line line;

        TouchDevice ControlTouchDevice;
        TouchPoint lastPoint1;
        TouchPoint lastPoint2;

        //To draw the line
        double Cuadro_X;
        double Cuadro_Y;
        double Cuadro2_X;
        double Cuadro2_Y;
        bool flag = false;
        bool lineStarted = false;
        bool lineDrawn = false;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void groupBox1_TouchDown(object sender, TouchEventArgs e)
        {
            // Capture to the groupbox.  
            e.TouchDevice.Capture(this.groupBox1);

            // Remember this contact if a contact has not been remembered already.  
            // This contact is then used to move the groupbox around.
            if (ControlTouchDevice == null)
            {
                ControlTouchDevice = e.TouchDevice;

                // Remember where this contact took place.  
                lastPoint1 = ControlTouchDevice.GetTouchPoint(this.canvas);

                if (!lineDrawn)
                {
                    //Line has been started
                    Cuadro_X = lastPoint1.Position.X;
                    Cuadro_Y = lastPoint1.Position.Y;
                    lineStarted = true;
                }
            }

            // Mark this event as handled.  
            e.Handled = true;
        }

        private void groupBox1_TouchMove(object sender, TouchEventArgs e)
        {
            if (e.TouchDevice == ControlTouchDevice)
            {
                //lineStarted = false;

                // Get the current position of the contact.  
                TouchPoint currentTouchPoint = ControlTouchDevice.GetTouchPoint(this.canvas);

                // Get the change between the controlling contact point and
                // the changed contact point.  
                double deltaX = currentTouchPoint.Position.X - lastPoint1.Position.X;
                double deltaY = currentTouchPoint.Position.Y - lastPoint1.Position.Y;

                // Get and then set a new top position and a new left position for the GroupBox.  
                double newTop = Canvas.GetTop(this.groupBox1) + deltaY;
                double newLeft = Canvas.GetLeft(this.groupBox1) + deltaX;

                // Get and then set a new top position and a new left position for the GroupBox.
                Canvas.SetTop(this.groupBox1, newTop);
                Canvas.SetLeft(this.groupBox1, newLeft);

                if (lineDrawn)
                {
                    this.line.X1 += deltaX;
                    this.line.Y1 += deltaY;
                }
                

                // Forget the old contact point, and remember the new contact point.  
                lastPoint1 = currentTouchPoint;

                // Mark this event as handled.  
                e.Handled = true;
            }
        }

        private void groupBox1_TouchLeave(object sender, TouchEventArgs e)
        {
            // If this contact is the one that was remembered  
            if (e.TouchDevice == ControlTouchDevice)
            {
                // Forget about this contact.
                ControlTouchDevice = null;
            }

            // Mark this event as handled.  
            e.Handled = true;



        }

        private void groupBox2_TouchDown(object sender, TouchEventArgs e)
        {
            // Capture to the groupbox.  
            e.TouchDevice.Capture(this.groupBox2);

            // Remember this contact if a contact has not been remembered already.  
            // This contact is then used to move the groupbox around.
            if (ControlTouchDevice == null)
            {
                ControlTouchDevice = e.TouchDevice;

                // Remember where this contact took place.  
                lastPoint2 = ControlTouchDevice.GetTouchPoint(this.canvas);
                Cuadro2_X = lastPoint2.Position.X;
                Cuadro2_Y = lastPoint2.Position.Y;

                if (lineStarted & !lineDrawn)
                {
                    line = new Line();
                    SolidColorBrush mySolidColorBrush = new SolidColorBrush();
                    mySolidColorBrush.Color = Color.FromArgb(255, 234, 234, 234);
                    line.Fill = mySolidColorBrush;
                    line.StrokeThickness = 2;
                    line.Stroke = Brushes.Black;
                    line.X1 = Cuadro_X;
                    line.Y1 = Cuadro_Y;
                    line.X2 = Cuadro2_X;
                    line.Y2 = Cuadro2_Y;
                    canvas.Children.Add(line);
                    lineStarted = false;
                    lineDrawn = true;
                }

             

            }

            // Mark this event as handled.  
            e.Handled = true;
        }

        private void groupBox2_TouchMove(object sender, TouchEventArgs e)
        {
            if (e.TouchDevice == ControlTouchDevice)
            {
                // Get the current position of the contact.  
                TouchPoint currentTouchPoint = ControlTouchDevice.GetTouchPoint(this.canvas);

                // Get the change between the controlling contact point and
                // the changed contact point.  
                double deltaX = currentTouchPoint.Position.X - lastPoint2.Position.X;
                double deltaY = currentTouchPoint.Position.Y - lastPoint2.Position.Y;

                // Get and then set a new top position and a new left position for the ellipse.  
                double newTop = Canvas.GetTop(this.groupBox2) + deltaY;
                double newLeft = Canvas.GetLeft(this.groupBox2) + deltaX;

                Canvas.SetTop(this.groupBox2, newTop);
                Canvas.SetLeft(this.groupBox2, newLeft);

                if (lineDrawn)
                {
                    this.line.X2 += deltaX;
                    this.line.Y2 += deltaY;
                }


                // Forget the old contact point, and remember the new contact point.  
                lastPoint2 = currentTouchPoint;

                // Mark this event as handled.  
                e.Handled = true;
            }
        }

        private void txtBox1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtBox1.Clear();
        }

        private void txtBox2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtBox2.Clear();
        }

        private void txtBox1_TouchDown(object sender, TouchEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtBox1.Text) || string.IsNullOrWhiteSpace(this.txtBox1.Text))
            {
                txtBox1.Clear();
            }
            txtBox1.Focus();
        }

        private void txtBox2_TouchDown(object sender, TouchEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtBox2.Text) || string.IsNullOrWhiteSpace(this.txtBox2.Text))
            {
                txtBox2.Clear();
            }
            
            txtBox2.Focus();
        }
    }
}
