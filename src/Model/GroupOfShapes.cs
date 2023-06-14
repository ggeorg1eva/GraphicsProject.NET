using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    public class GroupOfShapes
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private bool isSelected;
        public bool IsSelected
        {
            get { return isSelected; }
            set { isSelected = value; }
        }

        private List<Shape> shapes;
        public List<Shape> Shapes {
            get { return shapes; }
            set { shapes = value; }
        }

        public GroupOfShapes(int id, bool isSelected, List<Shape> shapes)
        {
            this.id = id;
            this.isSelected = isSelected;
            this.shapes = shapes;
        }

        public bool checkIfShapeIsInTheGroup(Shape shape)
        {
            return shapes.Contains(shape);
        }

        public void addShapeToTheGroup(Shape shape)
        {
            if (shapes.Contains(shape))
            {
                return;
            }
            shapes.Add(shape);
        }
    }
}
