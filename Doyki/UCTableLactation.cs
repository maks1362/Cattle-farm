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
    public partial class UCTableLactation : UserControl
    {
        int idChart = 0;
        int idCow = 0;

        public UCTableLactation()
        {
            InitializeComponent();
            this.lactationTableAdapter.Fill(this.uchot_udoevDataSet2.Lactation);
        }

        private void LactationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lactationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uchot_udoevDataSet2);
        }

        private void SearchStripButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lactationDataGridView.RowCount; i++)
            {
                lactationDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < lactationDataGridView.ColumnCount; j++)
                    if (lactationDataGridView.Rows[i].Cells[j].Value != null)
                        if (lactationDataGridView.Rows[i].Cells[j].Value.ToString().Contains(searchStripTextBox.Text))
                        {
                            lactationDataGridView.Rows[i].Selected = true;
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

        private void AnalysisOfMilkToolStripMenuItem_Click(object sender, EventArgs e)
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
                PdfPTable table = new PdfPTable(4);//MyDataSet.Tables[i].Columns.Count);
                                                   //Добавим в таблицу общий заголовок
                PdfPCell cell = new PdfPCell(new Phrase("Анализ молока коров"));
                cell.Colspan = 4;
                cell.HorizontalAlignment = 1;
                //Убираем границу первой ячейки, чтобы был как заголовок
                cell.Border = 0;
                table.AddCell(cell);
                //Сначала добавляем заголовки таблицы
                cell = new PdfPCell(new Phrase(new Phrase("Номер коровы", fontParagraph)));
                //Фоновый цвет (необязательно, просто сделаем по красивее)
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(new Phrase("Дата начала лактации", fontParagraph)));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(new Phrase("МДБ", fontParagraph)));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(new Phrase("МДЖ", fontParagraph)));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
                //Добавляем все остальные ячейки
                for (int j = 0; j < lactationDataGridView.RowCount - 1; j++)
                {
                    table.AddCell(new Phrase(lactationDataGridView.Rows[j].Cells[1].Value.ToString(), fontParagraph));
                    table.AddCell(new Phrase(lactationDataGridView.Rows[j].Cells[2].Value.ToString(), fontParagraph));
                    table.AddCell(new Phrase(lactationDataGridView.Rows[j].Cells[7].Value.ToString(), fontParagraph));
                    table.AddCell(new Phrase(lactationDataGridView.Rows[j].Cells[8].Value.ToString(), fontParagraph));
                }
                //Добавляем таблицу в документ
                doc.Add(table);
                //Закрываем документ
                doc.Close();
            }
        }

        private void InThisMonthToolStripMenuItem_Click(object sender, EventArgs e)
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
                PdfPCell cell = new PdfPCell(new Phrase("Какие коровы проходят лактацию в этом месяце"));
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
                cell = new PdfPCell(new Phrase(new Phrase("Дата начала лактации", fontParagraph)));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
                //Добавляем все остальные ячейки
                int[] id_cows = new int[lactationDataGridView.RowCount];
                int count_cows = 0;
                for (int j = 0; j < lactationDataGridView.RowCount - 1; j++)
                {
                    if (lactationDataGridView.Rows[j].Cells[2].Value != null && lactationDataGridView.Rows[j].Cells[2].Value.ToString().Length > 4)
                    {
                        if (Convert.ToDateTime(lactationDataGridView.Rows[j].Cells[2].Value).Date.Month >= DateTime.Today.Month &&
                        Convert.ToDateTime(lactationDataGridView.Rows[j].Cells[3].Value).Date.Month <= DateTime.Today.Month &&
                        (Convert.ToDateTime(lactationDataGridView.Rows[j].Cells[2].Value).Date.Year == DateTime.Today.Year || Convert.ToDateTime(lactationDataGridView.Rows[j].Cells[3].Value).Date.Year == DateTime.Today.Year) &&
                        !id_cows.Contains(Convert.ToInt32(lactationDataGridView.Rows[j].Cells[1].Value)))
                        {
                            table.AddCell(new Phrase(lactationDataGridView.Rows[j].Cells[1].Value.ToString(), fontParagraph));
                            table.AddCell(new Phrase(lactationDataGridView.Rows[j].Cells[2].Value.ToString(), fontParagraph));
                            id_cows[count_cows] = Convert.ToInt32(lactationDataGridView.Rows[j].Cells[1].Value);
                            count_cows++;
                        }
                    }
                }
                //Добавляем таблицу в документ
                doc.Add(table);
                //Закрываем документ
                doc.Close();
            }
        }

        private void NumberOfDaysToolStripMenuItem_Click(object sender, EventArgs e)
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
                PdfPCell cell = new PdfPCell(new Phrase("Количество дней в лактации"));
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
                cell = new PdfPCell(new Phrase(new Phrase("Дней в лактации", fontParagraph)));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
                //Добавляем все остальные ячейки
                int[] id_cows = new int[lactationDataGridView.RowCount];
                int count_cows = 0;
                for (int j = 0; j < lactationDataGridView.RowCount - 1; j++)
                {
                    if (lactationDataGridView.Rows[j].Cells[2].Value != null && lactationDataGridView.Rows[j].Cells[3].Value != null && lactationDataGridView.Rows[j].Cells[2].Value.ToString().Length > 4)
                    {
                        if (!id_cows.Contains(Convert.ToInt32(lactationDataGridView.Rows[j].Cells[1].Value)))
                        {
                            table.AddCell(new Phrase(lactationDataGridView.Rows[j].Cells[1].Value.ToString(), fontParagraph));
                            TimeSpan day = Convert.ToDateTime(lactationDataGridView.Rows[j].Cells[3].Value) - Convert.ToDateTime(lactationDataGridView.Rows[j].Cells[2].Value);
                            table.AddCell(new Phrase(day.Days.ToString(), fontParagraph));
                            id_cows[count_cows] = Convert.ToInt32(lactationDataGridView.Rows[j].Cells[1].Value);
                            count_cows++;
                        }
                    }
                }
                //Добавляем таблицу в документ
                doc.Add(table);
                //Закрываем документ
                doc.Close();
            }
        }

        private void lactationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int temp = lactationDataGridView.CurrentCell.RowIndex;
            idCow = Convert.ToInt32(lactationDataGridView[1, temp].Value);
        }

        private void MdbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idCow == 0)
                MessageBox.Show("Для построения графика необходимо выбрать корову из таблицы", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                idChart = 6;
                ChartForm chartForm = new ChartForm(this.idChart, this.idCow);
                this.Hide();
                chartForm.ShowDialog();
                this.Show();
            }
        }

        private void MdzhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idCow == 0)
                MessageBox.Show("Для построения графика необходимо выбрать корову из таблицы", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                idChart = 7;
                ChartForm chartForm = new ChartForm(this.idChart, this.idCow);
                this.Hide();
                chartForm.ShowDialog();
                this.Show();
            }
        }
    }
}
