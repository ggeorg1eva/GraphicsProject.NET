using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Draw
{
	/// <summary>
	/// Върху главната форма е поставен потребителски контрол,
	/// в който се осъществява визуализацията
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
		/// </summary>
		private DialogProcessor dialogProcessor = new DialogProcessor();

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		/// <summary>
		/// Изход от програмата. Затваря главната форма, а с това и програмата.
		/// </summary>
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}

		/// <summary>
		/// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
		/// </summary>
		void ViewPortPaint(object sender, PaintEventArgs e)
		{
			dialogProcessor.ReDraw(sender, e);
		}


		/// <summary>
		/// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
		/// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
		/// Промяна на статуса и инвалидиране на контрола, в който визуализираме.
		/// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
		/// </summary>
		void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (selectButton.Checked)
			{
				Shape selectedShape = dialogProcessor.ContainsPoint(e.Location);

				if (selectedShape != null)
				{
					if ((Control.ModifierKeys & Keys.Control) == Keys.Control && !this.dialogProcessor.IsGroupingOn)
					{
						// Селекткиране
						if (dialogProcessor.Selection.Contains(selectedShape))
						{
							dialogProcessor.Selection.Remove(selectedShape);
						}
						else
						{
							dialogProcessor.Selection.Add(selectedShape);
						}

					}
					else if (dialogProcessor.IsGroupingOn)
					{
						GroupOfShapes currentGroupOfShapes = null;
						int lastId = 0;
						foreach (GroupOfShapes group in this.dialogProcessor.Groups)
						{
							lastId = group.Id;
							if (group.IsSelected)
							{
								currentGroupOfShapes = group;
							}
						}

						if (currentGroupOfShapes == null)
						{
							currentGroupOfShapes = new GroupOfShapes(lastId + 1, true, new List<Shape>());
							this.dialogProcessor.Groups.Add(currentGroupOfShapes);
						}

						bool shouldAdd = true;
						foreach (GroupOfShapes group in dialogProcessor.Groups)
						{
							if (group.checkIfShapeIsInTheGroup(selectedShape))
                            {
								shouldAdd = false;
								break;
                            }
                        }

						if (shouldAdd)
                        {
							currentGroupOfShapes.addShapeToTheGroup(selectedShape);
						}

						dialogProcessor.Selection.Clear();
						foreach (Shape shape in currentGroupOfShapes.Shapes)
						{
							this.dialogProcessor.Selection.Add(shape);
						}
					}
					else if (dialogProcessor.IsUngroupingOn)
                    {
						foreach (GroupOfShapes group in dialogProcessor.Groups)
						{
							if (group.checkIfShapeIsInTheGroup(selectedShape))
							{
								group.IsSelected = true;
								group.Shapes.Remove(selectedShape);
							}
							else
							{
								group.IsSelected = false;
							}
						}
						dialogProcessor.Selection.Clear();
						this.dialogProcessor.Selection.Add(selectedShape);
					}
					else
					{
						GroupOfShapes group = dialogProcessor.returnGroupOfShape(selectedShape);
						dialogProcessor.Selection.Clear();
						dialogProcessor.Selection.Add(selectedShape);
						if (group != null)
                        {
							foreach (Shape shape in group.Shapes)
                            {
								if (dialogProcessor.Selection.Contains(shape))
                                {
									continue;
                                }
								dialogProcessor.Selection.Add(shape);

							}
						}
					}

					statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
					dialogProcessor.IsDragging = true;
					dialogProcessor.LastLocation = e.Location;
					viewPort.Invalidate();
				}
			}
		}

		/// <summary>
		/// Прихващане на преместването на мишката.
		/// Ако сме в режм на "влачене", то избрания елемент се транслира.
		/// </summary>
		void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (!dialogProcessor.IsDragging || dialogProcessor.Selection.Count <= 0)
            {
				return;
            }

			List<Shape> selectedShapes = dialogProcessor.Selection;

			List<GroupOfShapes> groupOfShapes = dialogProcessor.Groups;

			
			foreach (Shape shape in selectedShapes)
            {
				GroupOfShapes group = dialogProcessor.returnGroupOfShape(shape);
				if (group != null)
                {
					foreach (GroupOfShapes currentGroups in groupOfShapes)
                    {
						currentGroups.IsSelected = false;
                    }
					selectedShapes = group.Shapes;
					group.IsSelected = true;
				}
            }


			foreach (Shape selectedShape in selectedShapes)
            {
				int offsetX = (int)(e.Location.X - dialogProcessor.LastLocation.X);
				int offsetY = (int)(e.Location.Y - dialogProcessor.LastLocation.Y);

				selectedShape.Move(offsetX, offsetY);
				
				viewPort.Invalidate();
			}

			dialogProcessor.LastLocation = e.Location;

			statusBar.Items[0].Text = "Последно действие: Влачене";
		}

		/// <summary>
		/// Прихващане на отпускането на бутона на мишката.
		/// Излизаме от режим "влачене".
		/// </summary>
		void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			dialogProcessor.IsDragging = false;
		}

		/// <summary>
		/// Бутон, който поставя на произволно място правоъгълник със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomRectangle();

			statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";

			viewPort.Invalidate();
		}

		/// <summary>
		/// Бутон, който поставя на произволно място точка със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		private void DrawDotButton_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomDot();

			statusBar.Items[0].Text = "Последно действие: Рисуване на точка";

			viewPort.Invalidate();
		}
		/// <summary>
		/// Бутон, който поставя на произволно място отсечка със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		private void DrawLineButton_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomLine();

			statusBar.Items[0].Text = "Последно действие: Рисуване на отсечка";

			viewPort.Invalidate();
		}
		/// <summary>
		/// Бутон, който поставя на произволно място квадрат със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		private void DrawSquareButton_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomSquare();

			statusBar.Items[0].Text = "Последно действие: Рисуване на квадрат";

			viewPort.Invalidate();
		}
		/// <summary>
		/// Бутон, който поставя на произволно място триъгълник със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		private void DrawTriangleButton_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomTriangle();

			statusBar.Items[0].Text = "Последно действие: Рисуване на триъгълник";

			viewPort.Invalidate();
		}
		/// <summary>
		/// Бутон, който поставя на произволно място кръг със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		private void DrawCircleButton_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomCircle();

			statusBar.Items[0].Text = "Последно действие: Рисуване на кръг";

			viewPort.Invalidate();
		}
		/// <summary>
		/// Бутон, който поставя на произволно място елипса със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		private void DrawEllipseButton_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomEllipse();

			statusBar.Items[0].Text = "Последно действие: Рисуване на елипса";

			viewPort.Invalidate();
		}
		/// <summary>
		/// Бутон, който поставя на произволно място петоъгълник със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		private void DrawPentagonButton_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomPentagon();

			statusBar.Items[0].Text = "Последно действие: Рисуване на петоъгълник";

			viewPort.Invalidate();
		}
		/// <summary>
		/// Бутон, който поставя на произволно място шестоъгълник със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		private void DrawHexagonButton_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomHexagon();

			statusBar.Items[0].Text = "Последно действие: Рисуване на шестоъгълник";

			viewPort.Invalidate();
		}
		/// <summary>
		/// Бутон, който поставя на произволно място звезда със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		private void DrawStarButton_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomStar();

			statusBar.Items[0].Text = "Последно действие: Рисуване на звезда";

			viewPort.Invalidate();
		}
				
		/// <summary>
		/// Бутон, който поставя на произволно място ТЕКСТ .
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		private void addStringShapeButton_Click(object sender, EventArgs e)
        {
			if (!string.IsNullOrEmpty(addStringTextBox.Text))
			{
				dialogProcessor.AddRandomString(addStringTextBox.Text);
				statusBar.Items[0].Text = "Последно действие: Рисуване на тектс";
				viewPort.Invalidate();
			}
		}

        private void setBackgroundColorButton_Click(object sender, EventArgs e)
        {
			ColorDialog MyDialog = new ColorDialog();
			MyDialog.AllowFullOpen = false;
			MyDialog.ShowHelp = true;

			if (MyDialog.ShowDialog() == DialogResult.OK)
            {
				dialogProcessor.setFillColor(MyDialog.Color);
				viewPort.Invalidate();
				MyDialog.Dispose();
            }
		}

        private void setBorderColorButton_Click(object sender, EventArgs e)
        {
			ColorDialog MyDialog = new ColorDialog();
			MyDialog.AllowFullOpen = false;
			MyDialog.ShowHelp = true;

			if (MyDialog.ShowDialog() == DialogResult.OK)
			{
				dialogProcessor.setBorderColor(MyDialog.Color);
				viewPort.Invalidate();
				MyDialog.Dispose();
			}
		}

        private void transparencyTrackBar_Scroll(object sender, EventArgs e)
        {
			int trackBarMax = transparencyTrackBar.Maximum;
			int transparencyMax = 255;

			int transparency = (int)(((double)transparencyTrackBar.Value / trackBarMax) * transparencyMax);
			dialogProcessor.setTransparencyLevel(transparency);

			statusBar.Items[0].Text = "Последно действие: Промяна на прозрачност";
			viewPort.Invalidate();
		}

        private void rotationTrackBar_Scroll(object sender, EventArgs e)
        {
			int trackBarMax = rotateTrackBar.Maximum;
			int rotationMax = 360;

			int rotation = (int)(((double)rotateTrackBar.Value / trackBarMax) * rotationMax);
			dialogProcessor.setRotationAngle(rotation);

			statusBar.Items[0].Text = "Последно действие: Ротация";
			viewPort.Invalidate();
		}

        private void saveButton_Click(object sender, EventArgs e)
        {
			SaveFileDialog saveFileDialog = new SaveFileDialog();

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				dialogProcessor.saveFile(dialogProcessor.ShapeList, saveFileDialog.FileName);
			}

			statusBar.Items[0].Text = "Последно действие: Запазване";
			viewPort.Invalidate();
		}

        private void openButton_Click(object sender, EventArgs e)
        {
			OpenFileDialog openFileDialog = new OpenFileDialog();

			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				MessageBox.Show("There isn't inputted file", "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}


			if (!openFileDialog.FileName.EndsWith(".drw"))
            {
				MessageBox.Show("Invalid file", "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			dialogProcessor.openFile(openFileDialog.FileName);

			statusBar.Items[0].Text = "Последно действие: Отваряне";
			viewPort.Invalidate();
		}

        private void copyButton_Click(object sender, EventArgs e)
        {
			dialogProcessor.copySelectedObject();
			statusBar.Items[0].Text = "Последно действие: Копиране";
			viewPort.Invalidate();
		}

        private void deleteButton_Click(object sender, EventArgs e)
        {
			dialogProcessor.deleteSelectedObject();
			statusBar.Items[0].Text = "Последно действие: Триене";
			viewPort.Invalidate();
		}

		private void addImageButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				MessageBox.Show("There isn't inputted file", "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			dialogProcessor.addImage(openFileDialog.FileName);

			statusBar.Items[0].Text = "Последно действие: Отваряне";
			viewPort.Invalidate();
		}

        private void borderSizeCombobox_ItemSelected(object sender, EventArgs e)
        {
			object selectedItem = changeBorderSizeComboBox.SelectedItem;

			string selectedValue = selectedItem != null ? selectedItem.ToString() : null;

			Console.WriteLine(selectedValue);


			if (selectedValue == "Thin")
			{
				dialogProcessor.setBorderSizeLevel(1);
			} else if (selectedValue == "Medium")
			{
				dialogProcessor.setBorderSizeLevel(2);
			} else if (selectedValue == "Large")
            {
				dialogProcessor.setBorderSizeLevel(3);
			} else if (selectedValue == "Extra Large")
            {
				dialogProcessor.setBorderSizeLevel(4);
			}

			statusBar.Items[0].Text = "Последно действие: Промяна на дебелината на граница";
			viewPort.Invalidate();
		}

        private void resizeShapeTrackBar_Scroll(object sender, EventArgs e)
        {
			float selectedValue = resizeShapeTrackbar.Value;
			double scalingIndex = 1;

			if (selectedValue < 0) {
				scalingIndex = 1 + selectedValue / 4;
            } else if (selectedValue > 0) {
				scalingIndex = 1 + 3 * selectedValue / 40;
			}

			if (scalingIndex == 0)
            {
				return;
            }

			dialogProcessor.resizeSelectedShapes(scalingIndex);

			statusBar.Items[0].Text = "Последно действие: Промяна на мащаба " + scalingIndex + " пъти";
			viewPort.Invalidate();
		}

        private void groupButton_Click(object sender, EventArgs e)
        {
			this.stopGroupingButton_Click(sender, e);
			this.dialogProcessor.IsGroupingOn = true;
			this.stopGroupingButton.Text = "Stop Grouping";
			this.groupButton.BackColor = System.Drawing.Color.Silver;
		}

        private void stopGroupingButton_Click(object sender, EventArgs e)
        {
			this.dialogProcessor.IsGroupingOn = false;
			this.dialogProcessor.IsUngroupingOn = false;
			this.groupButton.BackColor = System.Drawing.SystemColors.Control;
			this.ungroupButton.BackColor = System.Drawing.SystemColors.Control;
			foreach (GroupOfShapes group in dialogProcessor.Groups)
			{
				group.IsSelected = false;
            }
		}

        private void ungroupButton_Click(object sender, EventArgs e)
        {
			this.stopGroupingButton_Click(sender, e);
			this.dialogProcessor.IsUngroupingOn = true;
			this.stopGroupingButton.Text = "Stop Ungrouping";
			this.ungroupButton.BackColor = System.Drawing.Color.Silver;
		}
    }
}
