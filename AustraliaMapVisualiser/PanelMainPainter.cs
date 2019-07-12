using System.Drawing;
using System.Windows.Forms;

namespace AustraliaMapVisualizer
{
    public class PanelMainPainter
    {
        private readonly Form1 _form1;
        protected internal double ChiInter;
        protected internal double ChiSlope;
        protected internal double EtaInter;
        protected internal double EtaSlope;
        protected internal Graphics Graphic;

        public PanelMainPainter(Form1 form1) => _form1 = form1;

        public void PanelMainPaint(object sender, PaintEventArgs e)
        {
            Graphic = e.Graphics;
            RectangleF clipRect = Graphic.VisibleClipBounds;

            Graphic.Clear(Color.White);

            var xMax = double.MinValue;
            var xMin = double.MaxValue;
            var yMax = double.MinValue;
            var yMin = double.MaxValue;

            _form1.Text = $"GraphForm {_form1.NumberOfCities} City Tour";
            foreach (City city in _form1.AllCities)
            {
                if (city.Point2D.getX() < xMin)
                    xMin = city.Point2D.getX();

                if (city.Point2D.getX() > xMax)
                    xMax = city.Point2D.getX();

                if (city.Point2D.getY() < yMin)
                    yMin = city.Point2D.getY();

                if (city.Point2D.getY() > yMax)
                    yMax = city.Point2D.getY();
            }

            ChiSlope = (clipRect.Width - 60f) / (xMax - xMin);
            ChiInter = clipRect.Left + 25 - ChiSlope * xMin;
            EtaSlope = (clipRect.Height - 45f) / (yMin - yMax);
            EtaInter = clipRect.Top + 25 - EtaSlope * yMax;

            var cityConnectionsPen = new Pen(Color.Black);
            var cityCirclePen = new Pen(Color.Red, 2f);
            var pathStartPointPen = new Pen(Color.Blue, 6f);
            var pathEndPointPen = new Pen(Color.Orange, 6f);
            var cityNameBrush = new SolidBrush(Color.DodgerBlue);
            var finalCityPathPen = new Pen(Color.Green, 3f);

            DrawFinalCityPath(finalCityPathPen);

            DrawCityConnectionAndCitiesCircles(cityCirclePen,
                cityConnectionsPen,
                cityNameBrush,
                pathStartPointPen,
                pathEndPointPen);
        }

        private void DrawCityConnectionAndCitiesCircles(Pen cityCirclePen,
            Pen cityConnectionsPen, SolidBrush cityNamePen,
            Pen pathStartPointPen, Pen pathEndPointPen)
        {
            foreach (City city in _form1.AllCities)
            {
                var chi1 = (float)(ChiSlope * city.Point2D.getX() + ChiInter);
                var eta1 = (float)(EtaSlope * city.Point2D.getY() + EtaInter);
                //Draw city circles
                Graphic.DrawEllipse(cityCirclePen, chi1 - 2, eta1 - 2, 4, 4);

                foreach (var nextCity in city.NextCities)
                {
                    var chi2 = (float)(ChiSlope * _form1.MapWithCities.getPosition(nextCity).getX() + ChiInter);
                    var eta2 = (float)(EtaSlope * _form1.MapWithCities.getPosition(nextCity).getY() + EtaInter);
                    //Draw connections between cities
                    Graphic.DrawLine(cityConnectionsPen, chi1, eta1, chi2, eta2);
                }

                Graphic.DrawString(city.Name, Control.DefaultFont, cityNamePen, chi1 - city.Name.Length * 3, eta1 + 4);
                Graphic.DrawEllipse(pathStartPointPen,
                    (float)(ChiSlope * _form1.MapWithCities.getPosition(_form1.RouteStartPosition).getX() + ChiInter) -
                    2,
                    (float)(EtaSlope * _form1.MapWithCities.getPosition(_form1.RouteStartPosition).getY() + EtaInter) -
                    2, 4,
                    4);
                Graphic.DrawEllipse(pathEndPointPen,
                    (float)(ChiSlope * _form1.MapWithCities.getPosition(_form1.RouteEndPosition).getX() + ChiInter) -
                    2,
                    (float)(EtaSlope * _form1.MapWithCities.getPosition(_form1.RouteEndPosition).getY() + EtaInter) -
                    2, 4, 4);
            }
        }

        private void DrawFinalCityPath(Pen greenPen)
        {
            //Draw FinalCityPath in green
            if (_form1.FinalCityPath != null)
                for (var i = 0; i < _form1.FinalCityPath.Count - 1; i++)
                {
                    var chi1 = (float)(ChiSlope * _form1.FinalCityPath[i].Point2D.getX() + ChiInter);
                    var eta1 = (float)(EtaSlope * _form1.FinalCityPath[i].Point2D.getY() + EtaInter);
                    var chi2 = (float)(ChiSlope * _form1.FinalCityPath[i + 1].Point2D.getX() + ChiInter);
                    var eta2 = (float)(EtaSlope * _form1.FinalCityPath[i + 1].Point2D.getY() + EtaInter);
                    Graphic.DrawLine(greenPen, chi1, eta1, chi2, eta2);
                }
        }
    }
}