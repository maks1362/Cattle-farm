using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doyki
{
    public partial class UCTableCattle : UserControl
    {
        private TreeCowForm treeCowForm;
        public UCTableCattle()
        {
            InitializeComponent();
            this.cattleTableAdapter.Fill(this.uchot_udoevDataSet2.Cattle);
            cattleDataGridView.DoubleBuffered(true);
        }

        private void CattleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cattleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uchot_udoevDataSet2);
        }

        //Ивент поиска по кнопке
        private void SearchStripButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cattleDataGridView.RowCount; i++)
            {
                cattleDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < cattleDataGridView.ColumnCount; j++)
                    if (cattleDataGridView.Rows[i].Cells[j].Value != null)
                        if (cattleDataGridView.Rows[i].Cells[j].Value.ToString().Contains(searchStripTextBox.Text))
                        {
                            cattleDataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = (MainForm)this.Parent;
            main.tableLayoutPanel1.Show();
        }

        private void ВапToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ГенеалогическоеДеревоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeCowForm = new TreeCowForm();
            int cowId;
            if (!int.TryParse(cattleDataGridView.Rows[cattleDataGridView.SelectedCells[0].RowIndex].Cells[0].Value.ToString(), out cowId))
            {
                MessageBox.Show("Выберете корову");
                return;
            }
            treeCowForm.RefreshImage(DrawBinaryTree(cattleDataGridView, cowId));
            treeCowForm.Show();
        }

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
            TreeView tree = new TreeView();
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
                    newNode = dataGrid[4, idGrid].Value.ToString();
                    if (newNode != "")
                    {
                        curNode.Nodes.Add(newNode, newNode);
                        nodeCount++;
                        GetNodes(curNode.Nodes[newNode], newNode);
                    }
                }
                else
                    return;

            }
        }
            /// <summary>	
            /// Метод рисует графическое изображение двоичного дерева	
            /// </summary>	
            /// <returns>Объект Bitmap</returns>	
        Bitmap DrawBinaryTree(DataGridView dataGrid, int cowId)
        {
            int nodeCount;//Содержит общее количество узлов дерева (и да, я знаю о treeView.VisibleCount, он не робит)	
            TreeView treeView = MakeTree(cowId, dataGrid, out nodeCount);
     
            /// Длина стороны прямоугольника изображающего вершину.	
            /// Я взял 11, исходя из рисунка. В реальности же, необходимо считать исходя из 	
            /// степени разветвлённости графа	
            int w = 25; // Math.Min(bmp.Width, bmp.Height) / 9;	
            Size s = new Size(w * 3, w);

            /// Задаём размер изображения, на котором будем рисовать	
            /// В данном случае привязка идёт к размерам PictureBox	
            /// Сам pictureBox хз как определить размер нужный	
            Bitmap bmp = new Bitmap(treeCowForm.pictureBox1.ClientSize.Width + nodeCount * w * 2, treeCowForm.pictureBox1.ClientSize.Height + nodeCount * w);

            /// Создаём Graphics из изображения	
            using (Graphics g = Graphics.FromImage(bmp))
            {

                using (Pen pen = new Pen(Color.Gray, 1.5f),// Перо для рисования прямоугольников	
                    arrowPen = new Pen(Color.Green, 2f) { EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor })
                {//Перо для рисования стрелок	
                    g.TranslateTransform(10, 10);//Отступ по 10 пикселей от верхнего левого угла изображения	
                                                    /// Массив точек, задающих верхний левый угол прямоугольника                                   	
                    Point[] points = new Point[nodeCount];
                    points[0] = new Point(0, 0);
                    int curPoint = 1;
                    int maxX = 0;
                    Get(treeView.Nodes[0], points[0]);
                    DrawVertex(g, pen, treeView.Nodes[0].Text.ToString(), points[0], s);

                    ///Рекурсивная магическая процедура, сам не знаю до конца как работает. Если смотреть на рисунок конечный	
                    ///Обход происхдит сверху вниз по первой ветке, затем 1 узел наверх и вправо до конца, 1 узел наверх и вправо до конца	
                    void Get(TreeNode treeNode, Point highPoint)
                    {
                        int pointsAtLevel = 0;
                        foreach (TreeNode tn in treeNode.Nodes)
                        {
                            ///Ставим точку, где будет узел дерева	
                            points[curPoint] = new Point(Convert.ToInt32(/*highPoint.X +*/ (pointsAtLevel * (w * 4)) + (maxX)), highPoint.Y + w * 3);
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
                        }
                        ///После достижения тупика в этой ветке	
                    }
                }
            }

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
