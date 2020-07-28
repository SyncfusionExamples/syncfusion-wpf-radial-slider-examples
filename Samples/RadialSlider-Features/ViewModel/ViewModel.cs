using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace RadialSlider_Features.ViewModel
{
    class ViewModel :NotificationObject
    {
        private double selectedValue;
        private double minimum = 0;
        private double maximum = 100;
        private double startAngle = 0;
        private double endAngle = 360;
        private int tickFrequency = 10;
        private double smallChange = 1;
        private double tickRadiusFactor = 0.72;
        private Visibility tickVisibility =  Visibility.Visible;
        private double labelRadiusFactor = 0.87;
        private Visibility labelVisibility =  Visibility.Visible;
        private double innerRimRadiusFactor = 0.2;
        private Brush innerRimFill =  Brushes.Yellow;
        private Brush innerRimStroke = Brushes.Red;
        private double innerRimStrokeThickness = 2;
        private double outerRimRadiusFactor = 0.7;
        private double pointerRadiusFactor = 0.75;
        private bool showMaximumValue = true;
        private Brush background = Brushes.SkyBlue;
        private Brush outerRimStroke = Brushes.Green;
        private Brush foreground = Brushes.Red;
        private SweepDirection sweepDirection = SweepDirection.Clockwise;
        private FlowDirection flowDirection =  FlowDirection.LeftToRight;

        public double SelectedValue
        {
            get
            {
                return selectedValue;
            }
            set
            {
                selectedValue = value;
                this.RaisePropertyChanged(nameof(SelectedValue));
            }
        } 
                
        public double Minimum
        {
            get
            {
                return minimum;
            }
            set
            {
                minimum = value;
                this.RaisePropertyChanged(nameof(Minimum));
            }
        }
        
        public double Maximum
        {
            get
            {
                return maximum;
            }
            set
            {
                maximum = value;
                this.RaisePropertyChanged(nameof(Maximum));
            }
        }
        public double StartAngle
        {
            get
            {
                return startAngle;
            }
            set
            {
                startAngle = value;
                this.RaisePropertyChanged(nameof(StartAngle));
            }
        }
        public double EndAngle
        {
            get
            {
                return endAngle;
            }
            set
            {
                endAngle = value;
                this.RaisePropertyChanged(nameof(EndAngle));
            }
        }
        
        public int TickFrequency
        {
            get
            {
                return tickFrequency;
            }
            set
            {
                tickFrequency = value;
                this.RaisePropertyChanged(nameof(TickFrequency));
            }
        } 
        
        public double SmallChange
        {
            get
            {
                return smallChange;
            }
            set
            {
                smallChange = value;
                this.RaisePropertyChanged(nameof(SmallChange));
            }
        }
        
        public double TickRadiusFactor
        {
            get
            {
                return tickRadiusFactor;
            }
            set
            {
                tickRadiusFactor = value;
                this.RaisePropertyChanged(nameof(TickRadiusFactor));
            }
        }
        
        public Visibility TickVisibility
        {
            get
            {
                return tickVisibility;
            }
            set
            {
                tickVisibility = value;
                this.RaisePropertyChanged(nameof(TickVisibility));
            }
        } 
        
        public double LabelRadiusFactor
        {
            get
            {
                return labelRadiusFactor;
            }
            set
            {
                labelRadiusFactor = value;
                this.RaisePropertyChanged(nameof(LabelRadiusFactor));
            }
        }
        
        public Visibility LabelVisibility
        {
            get
            {
                return labelVisibility;
            }
            set
            {
                labelVisibility = value;
                this.RaisePropertyChanged(nameof(LabelVisibility));
            }
        }
        
        public SweepDirection SweepDirection
        {
            get
            {
                return sweepDirection;
            }
            set
            {
                sweepDirection = value;
                this.RaisePropertyChanged(nameof(SweepDirection));
            }
        }
        
        public bool ShowMaximumValue
        {
            get
            {
                return showMaximumValue;
            }
            set
            {
                showMaximumValue = value;
                this.RaisePropertyChanged(nameof(ShowMaximumValue));
            }
        } 
        
        public Brush InnerRimFill
        {
            get
            {
                return innerRimFill;
            }
            set
            {
                innerRimFill = value;
                this.RaisePropertyChanged(nameof(InnerRimFill));
            }
        } 
        
        public Brush InnerRimStroke
        {
            get
            {
                return innerRimStroke;
            }
            set
            {
                innerRimStroke = value;
                this.RaisePropertyChanged(nameof(InnerRimStroke));
            }
        }
        
        public double InnerRimRadiusFactor
        {
            get
            {
                return innerRimRadiusFactor;
            }
            set
            {
                innerRimRadiusFactor = value;
                this.RaisePropertyChanged(nameof(InnerRimRadiusFactor));
            }
        }
        
        public double InnerRimStrokeThickness
        {
            get
            {
                return innerRimStrokeThickness;
            }
            set
            {
                innerRimStrokeThickness = value;
                this.RaisePropertyChanged(nameof(InnerRimStrokeThickness));
            }
        }
        public double OuterRimRadiusFactor
        {
            get
            {
                return outerRimRadiusFactor;
            }
            set
            {
                outerRimRadiusFactor = value;
                this.RaisePropertyChanged(nameof(OuterRimRadiusFactor));
            }
        }   

        public double PointerRadiusFactor
        {
            get
            {
                return pointerRadiusFactor;
            }
            set
            {
                pointerRadiusFactor = value;
                this.RaisePropertyChanged(nameof(PointerRadiusFactor));
            }
        }

        public Brush OuterRimStroke
        {
            get
            {
                return outerRimStroke;
            }
            set
            {
                outerRimStroke = value;
                this.RaisePropertyChanged(nameof(OuterRimStroke));
            }
        }

        public Brush Background
        {
            get
            {
                return background;
            }
            set
            {
                background = value;
                this.RaisePropertyChanged(nameof(Background));
            }
        }

        public Brush Foreground
        {
            get
            {
                return foreground;
            }
            set
            {
                foreground = value;
                this.RaisePropertyChanged(nameof(Foreground));
            }
        }  
        
        public FlowDirection FlowDirection
        {
            get
            {
                return flowDirection;
            }
            set
            {
                flowDirection = value;
                this.RaisePropertyChanged(nameof(FlowDirection));
            }
        }
    }
}
