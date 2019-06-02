using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Doyki
{
    public partial class MainForm : Form
    {
        //Загрузка котролов с таблицами
        private readonly UCTableCattle UCT1 = new UCTableCattle();
        private readonly UCTableAnalysisOfBlood UCT2 = new UCTableAnalysisOfBlood();
        private readonly UCTableLactation UCT3 = new UCTableLactation();
        private readonly UCTableApparat UCT4 = new UCTableApparat();
        private readonly UCTableReproductive UCT5 = new UCTableReproductive();

        //Для захвата позиции мышки
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        public MainForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        //Resize
        protected override void WndProc(ref Message m)
        {
            const UInt32 WM_NCHITTEST = 0x0084;
            const UInt32 WM_MOUSEMOVE = 0x0200;

            const UInt32 HTBOTTOMRIGHT = 17;

            const int RESIZE_HANDLE_SIZE = 30;
            bool handled = false;
            if (m.Msg == WM_NCHITTEST || m.Msg == WM_MOUSEMOVE)
            {
                Size formSize = this.Size;
                Point screenPoint = new Point(m.LParam.ToInt32());
                Point clientPoint = this.PointToClient(screenPoint);

                Dictionary<UInt32, Rectangle> boxes = new Dictionary<UInt32, Rectangle>() {{HTBOTTOMRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)}};

                foreach (KeyValuePair<UInt32, Rectangle> hitBox in boxes)
                {
                    if (hitBox.Value.Contains(clientPoint))
                    {
                        m.Result = (IntPtr)hitBox.Key;
                        handled = true;
                        break;
                    }
                }
            }

            if (!handled)
                base.WndProc(ref m);
        }

        //Закрыть
        protected virtual void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Сверенуть
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Создание доч. окна
        private void PlusWindowButton_Click(object sender, EventArgs e)
        {
            Form Child = new ChildForm();
            Child.Show();
        }

        private void NameLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void FullScreenButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void CattleButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Hide();
            this.Text = "Скот";
            nameLabel.Text = "Скот";
            if (this.UCT1.Parent == null)
            {
                this.Controls.Add(UCT1);
                this.UCT1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.UCT1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            }
            else
            {
                this.UCT1.Show();
            }
        }

        private void AnalysOfBloodButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Hide();
            this.Text = "Анализ крови";
            nameLabel.Text = "Анализ крови";
            if (this.UCT2.Parent == null)
            {
                this.Controls.Add(UCT2);
                this.UCT2.Dock = System.Windows.Forms.DockStyle.Fill;
                this.UCT2.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            }
            else
            {
                this.UCT2.Show();
            }

        }

        private void LactationButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Hide();
            this.Text = "Лактация";
            nameLabel.Text = "Лактация";
            if (this.UCT3.Parent == null)
            {
                this.Controls.Add(UCT3);
                this.UCT3.Dock = System.Windows.Forms.DockStyle.Fill;
                this.UCT3.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            }
            else
            {
                this.UCT3.Show();
            }
        }

        private void ApparatButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Hide();
            this.Text = "Доильный аппарат";
            nameLabel.Text = "Доильный аппарат";
            if (this.UCT4.Parent == null)
            {
                this.Controls.Add(UCT4);
                this.UCT4.Dock = System.Windows.Forms.DockStyle.Fill;
                this.UCT4.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            }
            else
            {
                this.UCT4.Show();
            }
        }

        private void ReproductiveButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Hide();
            this.Text = "Репродуктивность";
            nameLabel.Text = "Репродуктивность";
            if (this.UCT5.Parent == null)
            {
                this.Controls.Add(UCT5);
                this.UCT5.Dock = System.Windows.Forms.DockStyle.Fill;
                this.UCT5.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            }
            else
            {
                this.UCT5.Show();
            }
        }

        private void TableLayoutPanel1_VisibleChanged(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.Visible == true)
            {
                this.Text = "Выберите таблицу";
                nameLabel.Text = "Выберите таблицу";
            }
        }


               
        /// <summary>
        /// Метод рисует графическое изображение двоичного дерева
        /// </summary>
        /// <returns>Объект Bitmap</returns>
        Bitmap DrawBinaryTree(DataGridView dataGrid)
        {
            int nodeCount;//Содержит общее количество узлов дерева (и да, я знаю о treeView.VisibleCount, он не робит)
            TreeView treeView = MakeTree(237745, dataGrid, out nodeCount);
            
            //*Это тестовый вариант, раскомментируй, чтобы попробовать 
                treeView = new TreeView();
                treeView.Nodes.Add("1");
                treeView.Nodes[0].Nodes.Add("2");
                treeView.Nodes[0].Nodes.Add("3");
                treeView.Nodes[0].Nodes.Add("4");
                treeView.Nodes[0].Nodes.Add("41");
                treeView.Nodes[0].Nodes[0].Nodes.Add("5");
                treeView.Nodes[0].Nodes[2].Nodes.Add("6");
                treeView.Nodes[0].Nodes[3].Nodes.Add("61");
                treeView.Nodes[0].Nodes[3].Nodes.Add("61");
                treeView.Nodes[0].Nodes[3].Nodes[1].Nodes.Add("611");
                treeView.Nodes[0].Nodes[0].Nodes.Add("7");
                treeView.Nodes[0].Nodes[1].Nodes.Add("8");
                treeView.Nodes[0].Nodes[1].Nodes.Add("9");
                nodeCount = 13;
            

            /// Длина стороны прямоугольника изображающего вершину.
            /// Я взял 11, исходя из рисунка. В реальности же, необходимо считать исходя из 
            /// степени разветвлённости графа
            int w = 20; // Math.Min(bmp.Width, bmp.Height) / 9;
            Size s = new Size(w*3, w);

            /// Задаём размер изображения, на котором будем рисовать
            /// В данном случае привязка идёт к размерам PictureBox
            /// Сам pictureBox хз как определить размер нужный
            Bitmap bmp = new Bitmap(pictureBox1.ClientSize.Width + nodeCount * w*2, pictureBox1.ClientSize.Height + nodeCount * w);

            /// Создаём Graphics из изображения
            using (Graphics g = Graphics.FromImage(bmp))
            {

                using (Pen pen = new Pen(Color.Gray, 1.5f),// Перо для рисования прямоугольников
                    arrowPen = new Pen(Color.Green, 1.5f) { EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor })
                {//Перо для рисования стрелок
                    g.TranslateTransform(10, 10);//Отступ по 10 пикселей от верхнего левого угла изображения
                    /// Массив точек, задающих верхний левый угол прямоугольника                             
                    Point[] points = new Point[nodeCount];
                    points[0] = new Point(0, 0);
                    int curPoint = 1;
                    int maxX = 0;
                    Get(treeView.Nodes[0], points[0]);
                    DrawVertex(g, pen, treeView.Nodes[0].Text.ToString(), points[0], s);

                    /// Рисуем стрелки между прямоугольниками
                    //DrawArrows(g, arrowPen, points[0], points[1], s);

                    ///Рекурсивная магическая процедура, сам не знаю до конца как работает. Если смотреть на рисунок конечный
                    ///Обход происхдит сверху вниз по первой ветке, затем 1 узел наверх и вправо до конца, 1 узел наверх и вправо до конца
                void Get(TreeNode treeNode, Point highPoint)
                {
                        int pointsAtLevel = 0;
                        //maxPointsAtCol = 0;
                    foreach (TreeNode tn in treeNode.Nodes)
                    {
                            ///Ставим точку, где будет узел дерева
                        points[curPoint] = new Point(Convert.ToInt32(/*highPoint.X +*/ (pointsAtLevel * (w*4)) + (maxX)), highPoint.Y + w*3);
                        DrawArrows(g, arrowPen, highPoint, points[curPoint], s);
                            /// Рисуем прямоугольники. Это самое простое, если знать вершины
                        DrawVertex(g, pen, tn.Text.ToString(), points[curPoint], s);
                                pointsAtLevel++;
                        if (points[curPoint].X - w > maxX)
                            maxX = points[curPoint].X;
                        if (curPoint < nodeCount)
                        {
                            Get(tn, points[curPoint++]);
                        }
                            //pointsAtLevel = 0;
                    }
                        ///После достижения тупика в этой ветке
                    }
                }
            }
            
            //bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);//Ну типо перевернуть дерево))
            return bmp;
        }
        /// <summary>
        /// Метод прорисовки вершины графа
        /// </summary>
        /// <param name="g">Объект Graphics, в котором выполняется рисование</param>
        /// <param name="pen">Перо, которым выполняется рисование</param>
        /// <param name="text">Текст в вершине</param>
        /// <param name="pos">Положение верхнего левого угла</param>
        /// <param name="size">Размер</param>
        void DrawVertex(Graphics g, Pen pen, string text, Point pos, Size size)
        {
            /// Прямоугольник
            g.DrawRectangle(pen, new Rectangle(pos, size));
            /// Текст, высотой в 3/5 высоты прямоугольника
            g.DrawString(text, new Font(this.Font.Name, size.Height * 3f / 5f, this.Font.Style, GraphicsUnit.Pixel), Brushes.Black, pos);
        }

        /// <summary>
        /// Метод прорисовки стрелок между вершинами графа
        /// </summary>
        /// <param name="g">Объект Graphics, в котором выполняется рисование</param>
        /// <param name="pen">Перо, которым выполняется рисование</param>
        /// <param name="pos1">Верхний левый угол вершины, из которой выходит стрелка</param>
        /// <param name="pos2">Верхний левый угол вершины, в которую приходит стрелка</param>
        /// <param name="size">Размер прямоугольника</param>
        void DrawArrows(Graphics g, Pen pen, Point pos1, Point pos2, Size size)
        {
            Point pt1, pt2;
            /// Положение точки на середине нижней стороны прямоугольника
            pt1 = pos1; pt1.Offset(size.Width / 2, size.Height);
            /// Положение точки на середине верхней стороны прямоугольника
            pt2 = pos2; pt2.Offset(size.Width / 2, 0);
            g.DrawLine(pen, pt1, pt2);
        }
    }
}
