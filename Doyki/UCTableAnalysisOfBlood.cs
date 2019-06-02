using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Doyki
{
    public partial class UCTableAnalysisOfBlood : UserControl
    {
        int idChart = 0;
        int idCow = 0;

        public UCTableAnalysisOfBlood()
        {
            InitializeComponent();
            this.analysis_of_bloodTableAdapter.Fill(this.uchot_udoevDataSet2.Analysis_of_blood);
        }

        private void Analysis_of_bloodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.analysis_of_bloodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uchot_udoevDataSet2);

        }

        //Ивент поиска по кнопке
        private void SearchStripButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < analysis_of_bloodDataGridView.RowCount; i++)
            {
                analysis_of_bloodDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < analysis_of_bloodDataGridView.ColumnCount; j++)
                    if (analysis_of_bloodDataGridView.Rows[i].Cells[j].Value != null)
                        if (analysis_of_bloodDataGridView.Rows[i].Cells[j].Value.ToString().Contains(searchStripTextBox.Text))
                        {
                            analysis_of_bloodDataGridView.Rows[i].Selected = true;
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

        private void BloodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Сохранение";
            saveFileDialog1.FileName = "";
            saveFileDialog1.DefaultExt = "*.pdf";
            saveFileDialog1.Filter = "Файлы pdf (*.pdf)|*.pdf|Все файлы (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string SaveFileName = saveFileDialog1.FileName;

                //Объект документа пдф
                iTextSharp.text.Document doc = new iTextSharp.text.Document();
                //Создаем объект записи пдф-документа в файл
                PdfWriter.GetInstance(doc, new FileStream(SaveFileName, FileMode.Create));

                //Открываем документ
                doc.Open();

                //Определение шрифта необходимо для сохранения кириллического текста
                //Иначе мы не увидим кириллический текст
                //Если мы работаем только с англоязычными текстами, то шрифт можно не указывать
                string FONT_LOCATION = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.TTF"); //определяем В СИСТЕМЕ(чтобы не копировать файл) расположение шрифта arial.ttf
                BaseFont baseFont = BaseFont.CreateFont(FONT_LOCATION, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED); //создаем шрифт
                iTextSharp.text.Font fontParagraph = new iTextSharp.text.Font(baseFont, 17, iTextSharp.text.Font.NORMAL); //регистрируем + можно задать параметры для него(17 - размер, последний параметр - стиль)
                                                                                                                          //Создаем объект таблицы и передаем в нее число столбцов таблицы из нашего датасета
                PdfPTable table = new PdfPTable(2);//MyDataSet.Tables[i].Columns.Count);
                                                   //Добавим в таблицу общий заголовок
                PdfPCell cell = new PdfPCell(new Phrase("Группы крови коров"));
                cell.Colspan = 2;
                cell.HorizontalAlignment = 1;
                //Убираем границу первой ячейки, чтобы был как заголовок
                cell.Border = 0;
                table.AddCell(cell);
                //Сначала добавляем заголовки таблицы
                cell = new PdfPCell(new Phrase(new Phrase("Номер коровы", fontParagraph)));
                //Фоновый цвет (необязательно, просто сделаем по красивее)
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(new Phrase("Группа крови", fontParagraph)));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
                //Добавляем все остальные ячейки
                for (int j = 0; j < analysis_of_bloodDataGridView.RowCount - 1; j++)
                {
                    //for (int k = 0; k < 3; k++)
                    //{
                    table.AddCell(new Phrase(analysis_of_bloodDataGridView.Rows[j].Cells[1].Value.ToString(), fontParagraph));
                    table.AddCell(new Phrase(analysis_of_bloodDataGridView.Rows[j].Cells[3].Value.ToString(), fontParagraph));
                    //}
                }
                //Добавляем таблицу в документ
                doc.Add(table);
                //Закрываем документ
                doc.Close();
            }
        }

        private void analysis_of_bloodDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int temp = analysis_of_bloodDataGridView.CurrentCell.RowIndex;
            idCow = Convert.ToInt32(analysis_of_bloodDataGridView[1, temp].Value);
        }

        private void LactationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idCow == 0)
                MessageBox.Show("Для построения графика необходимо выбрать корову из таблицы", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                idChart = 1;
                ChartForm chartForm = new ChartForm(this.idChart, this.idCow);
                this.Hide();
                chartForm.ShowDialog();
                this.Show();
            }
        }

        private void BreedsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idCow == 0)
                MessageBox.Show("Для построения графика необходимо выбрать корову из таблицы", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                idChart = 2;
                ChartForm chartForm = new ChartForm(this.idChart, this.idCow);
                this.Hide();
                chartForm.ShowDialog();
                this.Show();
            }
        }

        private void LinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idCow == 0)
                MessageBox.Show("Для построения графика необходимо выбрать корову из таблицы", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                idChart = 3;
                ChartForm chartForm = new ChartForm(this.idChart, this.idCow);
                this.Hide();
                chartForm.ShowDialog();
                this.Show();
            }
        }

        private void FamiliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idCow == 0)
                MessageBox.Show("Для построения графика необходимо выбрать корову из таблицы", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                idChart = 4;
                ChartForm chartForm = new ChartForm(this.idChart, this.idCow);
                this.Hide();
                chartForm.ShowDialog();
                this.Show();
            }
        }

        private void AllAnimalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idChart = 5;
            ChartForm chartForm = new ChartForm(this.idChart, this.idCow);
            this.Hide();
            chartForm.ShowDialog();
            this.Show();
        }
    }
}
