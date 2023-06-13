using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Draw
{
	/// <summary>
	/// Класът, който ще бъде използван при управляване на диалога.
	/// </summary>
	public class DialogProcessor : DisplayProcessor
	{
		#region Constructor
		
		public DialogProcessor()
		{
            Selection = new List<Shape>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Избран елемент.
        /// </summary>
        private List<Shape> selection;
        public List<Shape> Selection { get { return selection; } set { selection = value; } 

    }

    /// <summary>
    /// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
    /// </summary>
    private bool isDragging;
		public bool IsDragging {
			get { return isDragging; }
			set { isDragging = value; }
		}
		
		/// <summary>
		/// Последна позиция на мишката при "влачене".
		/// Използва се за определяне на вектора на транслация.
		/// </summary>
		private PointF lastLocation;
		public PointF LastLocation {
			get { return lastLocation; }
			set { lastLocation = value; }
		}

        #endregion

        #region AddFigures
        /// <summary>
        /// Добавя примитив - правоъгълник на произволно място върху клиентската област.
        /// </summary>
        public void AddRandomRectangle()
		{
			Random rnd = new Random();
			int x = rnd.Next(100,1000);
			int y = rnd.Next(100,600);
			
			RectangleShape rect = new RectangleShape(new Rectangle(x,y,100,200));
			rect.FillColor = Color.White;

			ShapeList.Add(rect);
		}
        public void AddRandomSquare()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            SquareShape square = new SquareShape(new Rectangle(x, y, 100, 100));
            square.FillColor = Color.White;

            ShapeList.Add(square);
        }

        public void AddRandomEllipse()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, 200, 100));
            ellipse.FillColor = Color.White;

            ShapeList.Add(ellipse);
        }

        public void AddRandomCircle()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 500);

            CircleShape circle = new CircleShape(new Rectangle(x, y, 100, 100));
            circle.FillColor = Color.White;

            ShapeList.Add(circle);
        }

        public void AddRandomTriangle()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            TriangleShape triangle = new TriangleShape(new Rectangle(x, y, 100, 100));
            triangle.FillColor = Color.White;

            ShapeList.Add(triangle);
        }

        public void AddRandomLine()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            LineShape line = new LineShape(new Rectangle(x, y, x, y));
            line.FillColor = Color.White;

            ShapeList.Add(line);
        }

        public void AddRandomDot()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            DotShape dot = new DotShape(new Rectangle(x, y, 10, 10));

            ShapeList.Add(dot);
        }

        public void AddRandomPentagon()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            PentagonShape pentagon = new PentagonShape(new Rectangle(x, y, 100, 90));
            pentagon.FillColor = Color.White;

            ShapeList.Add(pentagon);
        }

        public void AddRandomHexagon()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            HexagonShape hex = new HexagonShape(new Rectangle(x, y, 100, 90));
            hex.FillColor = Color.White;

            ShapeList.Add(hex);
        }

        public void AddRandomStar()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            StarShape star = new StarShape(new Rectangle(x, y, 150, 90));
            star.FillColor = Color.White;

            ShapeList.Add(star);
        }
        public void AddRandomString(string text)
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            SizeF stringSize = new SizeF();
            stringSize = TextRenderer.MeasureText(text, new Font("Arial", 16));

            StringShape stringShape = new StringShape(new Rectangle(x, y, (int)stringSize.Width, (int)stringSize.Height));
            stringShape.Text = text;
            stringShape.FillColor = Color.Black;
            stringShape.Transparency = 255;

            ShapeList.Add(stringShape);
        }

        #endregion

        /// <summary>
        /// Проверява дали дадена точка е в елемента.
        /// Обхожда в ред обратен на визуализацията с цел намиране на
        /// "най-горния" елемент т.е. този който виждаме под мишката.
        /// </summary>
        /// <param name="point">Указана точка</param>
        /// <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>
        public Shape ContainsPoint(PointF point)
		{
			for(int i = ShapeList.Count - 1; i >= 0; i--){
				if (ShapeList[i].Contains(point)){
						
					return ShapeList[i];
				}	
			}
			return null;
		}
		
		/// <summary>
		/// Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
		/// </summary>
		/// <param name="p">Вектор на транслация.</param>
		public void TranslateTo(PointF p)
		{
            if (Selection != null)
            {
                float diffX = p.X - lastLocation.X;
                float diffY = p.Y - lastLocation.Y;

                foreach (Shape item in Selection)
                {
                    item.Location = new PointF(item.Location.X + diffX, item.Location.Y + diffY);
                }

                lastLocation = p;
            }
        }

        /// <summary>
		/// Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
		/// </summary>
		/// <param name="p">Вектор на транслация.</param>
		public void TranslateObjectTo(Shape shape, PointF p)
        {
            if (shape != null)
            {
                float diffX = p.X - lastLocation.X;
                float diffY = p.Y - lastLocation.Y;

                
                shape.Location = new PointF(shape.Location.X + diffX, shape.Location.Y + diffY);
                

                lastLocation = p;
            }
        }

        // <summary>
        // променя цвета на очертанията на избрания примтив
        // </summary>
        public void setBorderColor(Color color)
        {
            foreach (Shape item in Selection)
            {
                item.BorderColor = color;
            }
        }

        // <summary>
        // променя цвета заплъващ избрания примтив
        // </summary>
        public void setFillColor(Color color)
        {
            foreach (Shape item in Selection)
            {
                item.FillColor = color;
            }
        }

        // <summary>
        // променя прозрачността на избрания примтив
        // </summary>
        public void setTransparencyLevel(int transparency)
        {
            foreach (Shape item in Selection)
            {
                if (item.GetType() == typeof(ImageShape))
                {
                    MessageBox.Show("Image's transparency cannot be changed", "Image info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    item.GroupTransparency(transparency);
                    item.Transparency = transparency;
                }
            }
        }

        // <summary>
        // ротация на избрания примтив
        // </summary>
        public void setRotationAngle(int rotation)
        {
            foreach (Shape item in Selection)
            {
                if (item.GetType() == typeof(ImageShape))
                {
                    MessageBox.Show("Image's transparency cannot be changed", "Image info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    item.Angle = rotation;
                    item.GroupRotate(rotation);
                }
            }
        }


        //<summary>
        //променя дебелината на очертанието на избрания примитив
        //</summary>
        public void setBorderSizeLevel(int borderSize)
        {
            foreach (Shape item in Selection)
            {
                if (item.GetType() == typeof(ImageShape))
                {
                    MessageBox.Show("Image's border cannot be changed", "Image info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    item.GroupBorderSize(borderSize);
                    item.BorderSize = borderSize;
                }
            }
        }

        public void saveFile(object obj, string filePath = null)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream;
            if (filePath != null)
            {
                stream = new FileStream(filePath + ".drw", FileMode.Create);
            }
            else
            {
                stream = new FileStream("MyFile.drw", FileMode.Create, FileAccess.Write, FileShare.None);
            }
            formatter.Serialize(stream, obj);
            stream.Close();
        }

        public void openFile(string filePath)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None);

            object shapeList = formatter.Deserialize(stream);

            stream.Close();

            this.ShapeList = (List<Shape>) shapeList;
        }

        public void copySelectedObject()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            foreach (Shape item in Selection)
            {
                Shape copiedShape = DeepCopy(item);
                TranslateObjectTo(copiedShape, new PointF(x, y));
                ShapeList.Add(copiedShape);
            }
        }

        public static T DeepCopy<T>(T other)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(ms, other);
                ms.Position = 0;
                return (T)formatter.Deserialize(ms);
            }
        }

        public void deleteSelectedObject()
        {
            foreach (Shape item in Selection)
            {
                ShapeList.Remove(item);
            }
        }

        public void addImage(string filePath)
        {
            Bitmap image = new Bitmap(filePath);
            if (image == null)
            {
                MessageBox.Show("There isn't inputted image", "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            ImageShape imageShape = new ImageShape(image, new Rectangle(x, y, image.Width / 2, image.Height / 2));

            ShapeList.Add(imageShape);
        }
    }
}
