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

/*
 * Макс 26.03.19: Первая пункт меню будет комбо бокс из выбираемых таблиц(скот или доильные аппараты)
 * Далее пункт изменения данных в текущей таблице
 * Далее пункты отчётов и диаграмм(отдельные формы будут открываться)
 * */

//this.CommandCollection[1] = this.CommandCollection[1].Clone();
//this.CommandCollection[1].CommandText = "SELECT ID, Breed, Purity_of_breed, Gender, ID_mother, ID_father, Date_of_birth, D" +
//"ate_of_death, Cause_of_death, Belongs, Place_of_birth, Generation_number, Line F" +
//"ROM dbo.Cattle WHERE Date_of_birth IS NOT NULL";

namespace Doyki
{
    public partial class MainForm : Form
    {
        //Для захвата позиции мышки
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private const int cGrip = 300;
        private const int cCaption = 600;
        private TableForm TableFormCattle;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        //Переменные

        //static Form form = MainForm.ActiveForm;
        /*private static IList<string> dataTables = new List<string>
            {
                { "Скот" },//cattle
                { "Доильные аппараты" },//milking machine
                { "Лактации" },//и анализы молока
                { "Анализы крови" },//blood analyses
                { "Репродуктивность" }
               // new Element() { Symbol="Sc", Name="Scandium", AtomicNumber=21}},
            };*/




        /// <summary>
        /// Создаёт генеалогическое TreeView для коровы "cowId"
        /// </summary>
        /// <param name="cowId">Корова для которой строиться генеалогическое древо</param>
        /// <param name="dataGrid">Анализируемая таблица с коровами</param>
        /// <param name="nodeCountOut">Костыль для счёта общего количества узлов</param>
        /// <returns></returns>
        private TreeView MakeTree(int cowId, DataGridView dataGrid, out int nodeCountOut)
        {
            int nodeCount = 1;//Ещё один костыль, out переменные нельзя использовать во влож функциях
            TreeView tree = treeView1; // new TreeView();
            tree.Nodes.Add(new TreeNode(cowId.ToString()));
            GetNodes(tree.Nodes[0], cowId.ToString());

            nodeCountOut = nodeCount;
            return tree;


            ///Рекурсивная процедура создания генеологического древа для коровы
            void GetNodes(TreeNode curNode, string id) 
            {
                if (id != null)
                {
                    int idGrid = -1;
                    for (int i = 0; i < dataGrid.RowCount; i++)
                    {
                        if (dataGrid[0, i].Value.ToString() == id)
                        {
                            idGrid = i;
                            break;
                        }
                    }

                    string newNode = dataGrid[5, idGrid].Value.ToString();
                    if (newNode != "")
                    {
                        curNode.Nodes.Add(newNode, newNode);
                        nodeCount++;
                        GetNodes(curNode.Nodes[newNode], newNode);
                    }
                    //else
                        //MessageBox.Show("pizdaaaa2");
                }
                else
                    MessageBox.Show("xyiii1");
                return;

            }
        }

        public MainForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            CattleToolStripMenuItem_Click(null, null);
            pictureBox1.Image = DrawBinaryTree(TableFormCattle.dataGridView1);//
            

            //dataGrid = ;

        }

        /*public void Mess(string mes)
        {
            MessageBox.Show(mes);
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void CattleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.cattleTableAdapter1.Update(this.uchot_udoevDataSet1);
            //this.cattleTableAdapter1.FillMain(this.uchot_udoevDataSet1.Cattle);

            TableFormCattle = new TableFormCattle(this.uchot_udoevDataSet1.Cattle, this.cattleTableAdapter1);

            TableFormCattle.Show();

        }
        private void ApparatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableFormApparat(this.uchot_udoevDataSet1.Apparat, this.apparatTableAdapter1);
            tableForm.Show();
        }
        private void AnalysisOfBloodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableFormAnalysis_of_blood(this.uchot_udoevDataSet1.Analysis_of_blood, this.analysis_of_bloodTableAdapter1);
            tableForm.Show();
        }
        private void LactationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableFormLactation(this.uchot_udoevDataSet1.Lactation, this.lactationTableAdapter1);
            tableForm.Show();
        }
        private void ReproductiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableFormReproductive(this.uchot_udoevDataSet1.Reproductive, this.reproductiveTableAdapter1);
            tableForm.Show();
        }

        protected virtual void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PlusWindowButton_Click(object sender, EventArgs e)
        {
            Form Child  = new ChildForm();
            Child.Owner = this;
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

        //Resize - не работает  
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
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
